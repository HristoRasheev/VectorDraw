using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDraw.Models
{
    public class RectangleShape : Shape
    {
        public RectangleShape(Color initialColor) : base(initialColor) { }

        public override void Draw(Graphics g)
        {
            if (FillColor != Color.Transparent)
            {
                using Brush fillBrush = new SolidBrush(FillColor);
                g.FillRectangle(fillBrush, Position.X, Position.Y, Width, Height);
            }
            using (Pen pen = new Pen(this.Color, 4))
            {
                if (this.IsSelected)
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot; 
                }
                else
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }
                g.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
            }

            if (this.IsSelected)
            {
                g.FillRectangle(Brushes.Black,
                    new Rectangle(Position.X + Width - handleSize,
                    Position.Y + Height - handleSize, handleSize, handleSize));
            }
        }

        public override bool Contains(Point p)
        {
            return p.X >= Position.X && p.X <= Position.X + Width &&
                   p.Y >= Position.Y && p.Y <= Position.Y + Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override IShape CloneShape()
        {
            return new RectangleShape(Color)
            {
                Position = this.Position,
                Width = this.Width,
                Height = this.Height,
                IsSelected = this.IsSelected,
                FillColor = this.FillColor,
            };
        }
    }
}
