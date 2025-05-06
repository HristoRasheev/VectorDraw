using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace VectorDraw.Models
{
    public class Triangle : Shape
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }

        public Triangle(Point point1, Point point2, Point point3, Color color) : base(color)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Color = color;
        }

        //това е нужно за да правилно да се изчисли позицията на триъгълника с X и Y, 
        //а не със point кооординати
        public override Point Position
        {
            get
            {
                int minX = Math.Min(Point1.X, Math.Min(Point2.X, Point3.X));
                int minY = Math.Min(Point1.Y, Math.Min(Point2.Y, Point3.Y));
                return new Point(minX, minY);
            }
            set
            {
                Point oldPos = Position;
                int dx = value.X - oldPos.X;
                int dy = value.Y - oldPos.Y;
                Move(dx, dy);
            }
        }


        public override void Draw(Graphics g)
        {
            Point[] points = new Point[] { Point1, Point2, Point3 };

            if (FillColor != Color.Transparent)
            {
                using (Brush fillBrush = new SolidBrush(FillColor))
                {
                    g.FillPolygon(fillBrush, points);
                }
            }

            using (Pen solidPen = new Pen(Color, 4))
            {
                if(IsSelected)
                {
                    solidPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                }
                else
                {
                    solidPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }
                g.DrawPolygon(solidPen, points);
            }
            if(IsSelected)
            {
                g.FillRectangle(Brushes.Black,
                    new Rectangle(Point2.X - handleSize / 2, Point2.Y - handleSize / 2, handleSize, handleSize));
            }
        }

        public override bool Contains(Point p)
        {
            double area = GetArea();
            Triangle t1 = new Triangle(Point1, Point2, p, this.Color);
            Triangle t2 = new Triangle(Point2, Point3, p, this.Color);
            Triangle t3 = new Triangle(Point3, Point1, p, this.Color);
            double areaSum = t1.GetArea() + t2.GetArea() + t3.GetArea();

            return Math.Abs(area - areaSum) < 0.01;
        }

        public override double GetArea()
        {
            return Math.Abs(
                (Point1.X * (Point2.Y - Point3.Y) +
                Point2.X * (Point3.Y - Point1.Y) +
                Point3.X * (Point1.Y - Point2.Y)) / 2.0);
        }

        public override void Move(int dx, int dy)
        {
            Point1 = new Point(Point1.X + dx, Point1.Y + dy);
            Point2 = new Point(Point2.X + dx, Point2.Y + dy);
            Point3 = new Point(Point3.X + dx, Point3.Y + dy);
        }

        public override bool MouseOnResizeHandle(Point p)
        {
            const int handleSize = 10;
            var handleRect = new Rectangle(
                Point2.X - handleSize / 2,
                Point2.Y - handleSize / 2,
                handleSize,
                handleSize
            );
            return handleRect.Contains(p);
        }

        public override void Resize(int dx, int dy)
        {
            PointF center = GetCenter();
            float oldDist = Distance(center, Point2);
            float newDist = oldDist + dx;  

            if (newDist < 0) newDist = 0;

            float scale = newDist / oldDist;

            Point1 = Point.Round(ScalePointF(Point1, center, scale));
            Point2 = Point.Round(ScalePointF(Point2, center, scale));
            Point3 = Point.Round(ScalePointF(Point3, center, scale));
        }

        private PointF ScalePointF(Point original, PointF center, float scale)
        {
            float dx = original.X - center.X;
            float dy = original.Y - center.Y;
            return new PointF(
                center.X + dx * scale,
                center.Y + dy * scale
            );
        }

        private float Distance(PointF p1, Point p2)
        {
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        private PointF GetCenter()
        {
            return new PointF(
                (Point1.X + Point2.X + Point3.X) / 3f,
                (Point1.Y + Point2.Y + Point3.Y) / 3f
            );
        }

        public override IShape CloneShape()
        {
            return new Triangle(
                        new Point(Point1.X, Point1.Y),
                        new Point(Point2.X, Point2.Y),
                        new Point(Point3.X, Point3.Y),
                        this.Color)
            {
                FillColor = this.FillColor,
                IsSelected = this.IsSelected
            };
        }
    }
}

