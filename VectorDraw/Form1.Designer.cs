namespace VectorDraw
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            SaveButton = new ToolStripMenuItem();
            LoadButton = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            clearTheWholeBoardToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonTriangle = new Button();
            buttonRectangle = new Button();
            buttonCircle = new Button();
            drawingBoard = new Panel();
            buttonRedo = new Button();
            buttonUndo = new Button();
            InfoPanel = new Panel();
            labelY = new Label();
            labelX = new Label();
            labelArea = new Label();
            labelFigures = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            buttonDeleteFig = new Button();
            buttonChangeColorOfBorders = new Button();
            buttonFillFig = new Button();
            buttonSelectFig = new Button();
            panel2 = new Panel();
            panel6 = new Panel();
            label12 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            drawingBoard.SuspendLayout();
            InfoPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(4, 72, 125);
            menuStrip1.Font = new Font("Rockwell", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(1485, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveButton, LoadButton });
            fileToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(66, 30);
            fileToolStripMenuItem.Text = "File";
            // 
            // SaveButton
            // 
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(149, 30);
            SaveButton.Text = "Save";
            SaveButton.Click += SaveButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(149, 30);
            LoadButton.Text = "Load";
            LoadButton.Click += LoadButton_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearTheWholeBoardToolStripMenuItem });
            editToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(68, 30);
            editToolStripMenuItem.Text = "Edit";
            // 
            // clearTheWholeBoardToolStripMenuItem
            // 
            clearTheWholeBoardToolStripMenuItem.Name = "clearTheWholeBoardToolStripMenuItem";
            clearTheWholeBoardToolStripMenuItem.Size = new Size(336, 30);
            clearTheWholeBoardToolStripMenuItem.Text = "Clear the whole board";
            clearTheWholeBoardToolStripMenuItem.Click += clearTheWholeBoardToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonTriangle);
            panel1.Controls.Add(buttonRectangle);
            panel1.Controls.Add(buttonCircle);
            panel1.Location = new Point(13, 79);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 233);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label3.Location = new Point(75, 165);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 38);
            label3.TabIndex = 5;
            label3.Text = "Triangle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label2.Location = new Point(75, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 38);
            label2.TabIndex = 4;
            label2.Text = "Circle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label1.Location = new Point(72, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 3;
            label1.Text = "Rectangle";
            // 
            // buttonTriangle
            // 
            buttonTriangle.BackgroundImage = (Image)resources.GetObject("buttonTriangle.BackgroundImage");
            buttonTriangle.BackgroundImageLayout = ImageLayout.Stretch;
            buttonTriangle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTriangle.Location = new Point(11, 155);
            buttonTriangle.Margin = new Padding(2, 3, 2, 3);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(59, 55);
            buttonTriangle.TabIndex = 2;
            buttonTriangle.UseVisualStyleBackColor = true;
            buttonTriangle.Click += buttonTriangle_Click;
            // 
            // buttonRectangle
            // 
            buttonRectangle.BackgroundImage = (Image)resources.GetObject("buttonRectangle.BackgroundImage");
            buttonRectangle.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRectangle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRectangle.Location = new Point(11, 19);
            buttonRectangle.Margin = new Padding(2, 3, 2, 3);
            buttonRectangle.Name = "buttonRectangle";
            buttonRectangle.Size = new Size(58, 63);
            buttonRectangle.TabIndex = 0;
            buttonRectangle.UseVisualStyleBackColor = true;
            buttonRectangle.Click += buttonRectangle_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.BackgroundImage = (Image)resources.GetObject("buttonCircle.BackgroundImage");
            buttonCircle.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCircle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCircle.Location = new Point(11, 88);
            buttonCircle.Margin = new Padding(2, 3, 2, 3);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(59, 61);
            buttonCircle.TabIndex = 1;
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // drawingBoard
            // 
            drawingBoard.BackColor = Color.WhiteSmoke;
            drawingBoard.BackgroundImage = (Image)resources.GetObject("drawingBoard.BackgroundImage");
            drawingBoard.BackgroundImageLayout = ImageLayout.Center;
            drawingBoard.BorderStyle = BorderStyle.FixedSingle;
            drawingBoard.Controls.Add(buttonRedo);
            drawingBoard.Controls.Add(buttonUndo);
            drawingBoard.Controls.Add(InfoPanel);
            drawingBoard.Location = new Point(310, 53);
            drawingBoard.Margin = new Padding(2, 3, 2, 3);
            drawingBoard.Name = "drawingBoard";
            drawingBoard.Size = new Size(1151, 725);
            drawingBoard.TabIndex = 2;
            drawingBoard.Paint += drawingBoard_Paint;
            drawingBoard.MouseDown += drawingBoard_MouseDown;
            drawingBoard.MouseMove += drawingBoard_MouseMove;
            drawingBoard.MouseUp += drawingBoard_MouseUp;
            // 
            // buttonRedo
            // 
            buttonRedo.BackgroundImage = (Image)resources.GetObject("buttonRedo.BackgroundImage");
            buttonRedo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonRedo.Location = new Point(71, 19);
            buttonRedo.Margin = new Padding(2, 3, 2, 3);
            buttonRedo.Name = "buttonRedo";
            buttonRedo.Size = new Size(50, 59);
            buttonRedo.TabIndex = 2;
            buttonRedo.UseVisualStyleBackColor = true;
            buttonRedo.Click += buttonRedo_Click;
            // 
            // buttonUndo
            // 
            buttonUndo.BackgroundImage = (Image)resources.GetObject("buttonUndo.BackgroundImage");
            buttonUndo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUndo.Location = new Point(18, 19);
            buttonUndo.Margin = new Padding(2, 3, 2, 3);
            buttonUndo.Name = "buttonUndo";
            buttonUndo.Size = new Size(48, 59);
            buttonUndo.TabIndex = 1;
            buttonUndo.UseVisualStyleBackColor = true;
            buttonUndo.Click += buttonUndo_Click;
            // 
            // InfoPanel
            // 
            InfoPanel.BackColor = Color.FromArgb(85, 227, 75);
            InfoPanel.BorderStyle = BorderStyle.FixedSingle;
            InfoPanel.Controls.Add(labelY);
            InfoPanel.Controls.Add(labelX);
            InfoPanel.Controls.Add(labelArea);
            InfoPanel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoPanel.Location = new Point(18, 639);
            InfoPanel.Margin = new Padding(2, 3, 2, 3);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(698, 65);
            InfoPanel.TabIndex = 0;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Font = new Font("Rockwell", 22.2F);
            labelY.Location = new Point(501, 11);
            labelY.Margin = new Padding(2, 0, 2, 0);
            labelY.Name = "labelY";
            labelY.Size = new Size(53, 42);
            labelY.TabIndex = 2;
            labelY.Text = "Y:";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Rockwell", 22.2F);
            labelX.Location = new Point(307, 11);
            labelX.Margin = new Padding(2, 0, 2, 0);
            labelX.Name = "labelX";
            labelX.Size = new Size(53, 42);
            labelX.TabIndex = 1;
            labelX.Text = "X:";
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Font = new Font("Rockwell", 22.2F);
            labelArea.Location = new Point(10, 11);
            labelArea.Margin = new Padding(2, 0, 2, 0);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(111, 42);
            labelArea.TabIndex = 0;
            labelArea.Text = "Area:";
            // 
            // labelFigures
            // 
            labelFigures.AutoSize = true;
            labelFigures.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFigures.ForeColor = Color.FromArgb(0, 0, 64);
            labelFigures.Location = new Point(17, 27);
            labelFigures.Margin = new Padding(2, 0, 2, 0);
            labelFigures.Name = "labelFigures";
            labelFigures.Size = new Size(216, 54);
            labelFigures.TabIndex = 4;
            labelFigures.Text = "Figures:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(buttonDeleteFig);
            panel3.Controls.Add(buttonChangeColorOfBorders);
            panel3.Controls.Add(buttonFillFig);
            panel3.Controls.Add(buttonSelectFig);
            panel3.Location = new Point(10, 75);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 263);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label7.Location = new Point(85, 205);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 38);
            label7.TabIndex = 9;
            label7.Text = "Delete";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label6.Location = new Point(79, 141);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 38);
            label6.TabIndex = 6;
            label6.Text = "Borders";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label5.Location = new Point(85, 85);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 38);
            label5.TabIndex = 8;
            label5.Text = "Fill ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            label4.Location = new Point(79, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 38);
            label4.TabIndex = 6;
            label4.Text = "Select";
            // 
            // buttonDeleteFig
            // 
            buttonDeleteFig.BackgroundImage = (Image)resources.GetObject("buttonDeleteFig.BackgroundImage");
            buttonDeleteFig.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDeleteFig.Location = new Point(11, 201);
            buttonDeleteFig.Margin = new Padding(2, 3, 2, 3);
            buttonDeleteFig.Name = "buttonDeleteFig";
            buttonDeleteFig.Size = new Size(59, 55);
            buttonDeleteFig.TabIndex = 7;
            buttonDeleteFig.UseVisualStyleBackColor = true;
            buttonDeleteFig.Click += buttonDeleteFig_Click;
            // 
            // buttonChangeColorOfBorders
            // 
            buttonChangeColorOfBorders.BackgroundImage = (Image)resources.GetObject("buttonChangeColorOfBorders.BackgroundImage");
            buttonChangeColorOfBorders.BackgroundImageLayout = ImageLayout.Stretch;
            buttonChangeColorOfBorders.Location = new Point(11, 141);
            buttonChangeColorOfBorders.Margin = new Padding(2, 3, 2, 3);
            buttonChangeColorOfBorders.Name = "buttonChangeColorOfBorders";
            buttonChangeColorOfBorders.Size = new Size(59, 55);
            buttonChangeColorOfBorders.TabIndex = 6;
            buttonChangeColorOfBorders.UseVisualStyleBackColor = true;
            buttonChangeColorOfBorders.Click += buttonChangeColorOfBorders_Click;
            // 
            // buttonFillFig
            // 
            buttonFillFig.BackgroundImage = (Image)resources.GetObject("buttonFillFig.BackgroundImage");
            buttonFillFig.BackgroundImageLayout = ImageLayout.Stretch;
            buttonFillFig.Location = new Point(11, 81);
            buttonFillFig.Margin = new Padding(2, 3, 2, 3);
            buttonFillFig.Name = "buttonFillFig";
            buttonFillFig.Size = new Size(59, 55);
            buttonFillFig.TabIndex = 5;
            buttonFillFig.UseVisualStyleBackColor = true;
            buttonFillFig.Click += buttonFillFig_Click;
            // 
            // buttonSelectFig
            // 
            buttonSelectFig.BackgroundImage = (Image)resources.GetObject("buttonSelectFig.BackgroundImage");
            buttonSelectFig.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSelectFig.Location = new Point(11, 16);
            buttonSelectFig.Margin = new Padding(2, 3, 2, 3);
            buttonSelectFig.Name = "buttonSelectFig";
            buttonSelectFig.Size = new Size(58, 60);
            buttonSelectFig.TabIndex = 3;
            buttonSelectFig.UseVisualStyleBackColor = true;
            buttonSelectFig.Click += buttonSelectFig_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(102, 172, 242);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelFigures);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(11, 53);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 337);
            panel2.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(102, 172, 242);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label12);
            panel6.Controls.Add(panel3);
            panel6.Location = new Point(11, 413);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(276, 365);
            panel6.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 0, 64);
            label12.Location = new Point(19, 35);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(215, 54);
            label12.TabIndex = 4;
            label12.Text = "Actions:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 253, 255);
            ClientSize = new Size(1485, 797);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Controls.Add(drawingBoard);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Vector Draw :D";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            drawingBoard.ResumeLayout(false);
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Panel panel1;
        private Panel drawingBoard;
        private Panel panel3;
        private Panel InfoPanel;
        private Button buttonTriangle;
        private Button buttonCircle;
        private Button buttonRectangle;
        private Label labelY;
        private Label labelX;
        private Button buttonSelectFig;
        private Button buttonFillFig;
        private Label labelFigures;
        private Button buttonRedo;
        private Button buttonUndo;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem clearTheWholeBoardToolStripMenuItem;
        private Label labelArea;
        private Panel panel2;
        private Button buttonChangeColorOfBorders;
        private Button buttonDeleteFig;
        private ToolStripMenuItem LoadButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel6;
        private Label label12;
    }
}
