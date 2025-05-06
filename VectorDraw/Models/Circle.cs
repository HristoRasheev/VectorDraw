using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDraw.Models
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle(Color initialColor, float radius, Point position)
            : base(initialColor)
        {
            Radius = radius;
            Position = position;
        }

        public override int Width
        {
            get => (int)(Radius * 2);
            set => Radius = value / 2f;
        }
        public override int Height
        {
            get => (int)(Radius * 2);
            set => Radius = value / 2f;
        }

        public override void Draw(Graphics g)
        {
            if (FillColor != Color.Transparent)
            {
                using Brush fillBrush = new SolidBrush(FillColor);
                g.FillEllipse(fillBrush, Position.X - Radius, Position.Y - Radius, Width, Height);
            }
            using (Pen pen = new Pen(Color, 4))
            {
                if (IsSelected)
                {
                    pen.DashStyle = DashStyle.Dot;
                }
                else
                {
                    pen.DashStyle = DashStyle.Solid;
                }
                g.DrawEllipse(pen, Position.X - Radius, Position.Y - Radius, Width, Height);
            }
            if (IsSelected)
            {
                g.FillRectangle(Brushes.Black,
                    new Rectangle(Position.X + (int)Radius - handleSize,
                                  Position.Y + (int)Radius - handleSize,
                                  handleSize, handleSize));
            }
        }

        public override bool Contains(Point p)
        {
            double dx = p.X - Position.X;
            double dy = p.Y - Position.Y;
            return dx * dx + dy * dy <= Radius * Radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override bool MouseOnResizeHandle(Point p)
        {
            var handleX = Position.X + (int)Radius - handleSize;
            var handleY = Position.Y + (int)Radius - handleSize;

            return new Rectangle(handleX, handleY, handleSize, handleSize).Contains(p);
        }

        public override IShape CloneShape()
        {
            return new Circle(this.Color, this.Radius, this.Position)
            {
                FillColor = this.FillColor,
                IsSelected = this.IsSelected
            };
        }

    }
}
