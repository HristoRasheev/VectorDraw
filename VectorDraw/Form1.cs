using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using VectorDraw.Models;

namespace VectorDraw
{
    public partial class Form1 : Form
    {
        private List<IShape> shapes;
        private Shape? selectedShape;
        private bool SelectedMode = false;
        private Point lastMousePosition;
        private bool isResizing = false;

        private Stack<List<IShape>> undoStack = new Stack<List<IShape>>();
        private Stack<List<IShape>> redoStack = new Stack<List<IShape>>();

        public Form1()
        {
            InitializeComponent();
            // Това е за да не примигват фигурите при местене
            drawingBoard.GetType()
                .GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(drawingBoard, true, null);

            // Създаваме списък, в който да съхраняваме фигурите
            shapes = new List<IShape>();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Използваме го за Undo и Redo
        private void SaveState()
        {
            undoStack.Push(shapes.Select(x => x.CloneShape()).ToList());
            redoStack.Clear();
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            var rect = new RectangleShape(Color.Blue)
            {
                Width = 100,
                Height = 60,
                Position = new Point(100, 100)
            };

            shapes.Add(rect);
            SaveState();
            drawingBoard.Invalidate();
        }
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            var circle = new Circle(Color.Green, 50, new Point(200, 200));

            shapes.Add(circle);
            SaveState();
            drawingBoard.Invalidate();
        }
        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            var triangle = new Triangle(
                new Point(300, 300),
                new Point(350, 400),
                new Point(250, 400),
                Color.Red);

            shapes.Add(triangle);
            SaveState();
            drawingBoard.Invalidate();
        }

        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }
        }

        private void drawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (!SelectedMode) return;

            if (SelectedMode)
            {
                SaveState();
            }

            foreach (var shape in shapes)
            {
                if (shape is Shape s)
                {
                    s.IsSelected = false;
                }
            }

            foreach (var shape in shapes)
            {
                if (shape is Shape s)
                {
                    if (s.MouseOnResizeHandle(e.Location))
                    {
                        selectedShape = s;
                        isResizing = true;
                        lastMousePosition = e.Location;
                        return;
                    }
                    else if (shape.Contains(e.Location))
                    {
                        selectedShape = s;
                        selectedShape.IsSelected = true;
                        lastMousePosition = e.Location;
                        UpdateInfoPanel(s);
                        drawingBoard.Invalidate();
                        return;
                    }
                }
            }
        }

        private void drawingBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (!SelectedMode || selectedShape == null)
                return;

            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - lastMousePosition.X;
                int dy = e.Y - lastMousePosition.Y;

                if (isResizing)
                {
                    selectedShape.Resize(dx, dy);
                }
                else
                {
                    selectedShape.Move(dx, dy);
                }

                lastMousePosition = e.Location;
                drawingBoard.Invalidate();
                UpdateInfoPanel(selectedShape);
            }
        }

        private void drawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
        }

        private void buttonSelectFig_Click(object sender, EventArgs e)
        {
            SelectedMode = !SelectedMode;

            if (!SelectedMode)
            {
                foreach (var shape in shapes)
                {
                    if (shape is Shape s)
                    {
                        s.IsSelected = false;
                    }
                }
            }
            selectedShape = null;
            drawingBoard.Invalidate();

            if (SelectedMode)
            {
                buttonSelectFig.BackColor = Color.LightGreen;
            }
            else
            {
                buttonSelectFig.BackColor = SystemColors.Control;
            }
        }

        private void UpdateInfoPanel(Shape shape)
        {
            int shapeCount = shapes.Count();
            Console.WriteLine($"Shape count: {shapeCount}");

            if (shape != null)
            {
                labelArea.Text = $"Area: {Math.Round(shape.GetArea(), 2)}px";
                labelX.Text = $"X: {shape.Position.X}";
                labelY.Text = $"Y: {shape.Position.Y}";
            }
            else
            {
                labelArea.Text = "Area:";
                labelX.Text = "X:";
                labelY.Text = "Y:";
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(shapes.Select(x => x.CloneShape()).ToList());
                shapes = undoStack.Pop();
                drawingBoard.Invalidate();
            }
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(shapes.Select(x => x.CloneShape()).ToList());
                shapes = redoStack.Pop();
                drawingBoard.Invalidate();
            }
        }

        private void buttonFillFig_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedShape.FillColor = colorDialog.Color;
                    drawingBoard.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Please select a shape to fill first.");
            }
        }

        private void clearTheWholeBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all shapes?", "Clear Shapes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaveState();
                shapes.Clear();
                drawingBoard.Invalidate();
            }
        }

        private void buttonChangeColorOfBorders_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedShape.Color = colorDialog.Color;
                    drawingBoard.Invalidate();
                }
            }
            else
            {
                MessageBox.Show("Please select a shape to change its border color.");
            }
        }

        private void buttonDeleteFig_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                SaveState();
                shapes = shapes.Where(s => s != selectedShape).ToList();
                selectedShape = null;
                drawingBoard.Invalidate();
            }
            else
            {
                MessageBox.Show("Please select a shape to delete.");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "JSON Files (*.json)|*.json",
                DefaultExt = "json"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StoringShapes.SaveToFile(dialog.FileName, shapes);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "JSON Files (*.json)|*.json"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                shapes = StoringShapes.LoadFromFile(dialog.FileName);
                drawingBoard.Invalidate();
            }
        }
    }
}
