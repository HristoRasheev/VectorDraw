using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDraw.Models
{
    public abstract class Shape : IShape
    {
        public Color Color { get; set; }
        public Color OriginalColor { get; private set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual Point Position { get; set; }
        public bool IsSelected { get; set; } = false;
        public Color FillColor { get; set; }

        protected const int handleSize = 8;

        public Shape(Color initialColor)
        {
            Color = initialColor;
        }

        public abstract void Draw(Graphics g);

        public abstract bool Contains(Point p);

        public abstract double GetArea();

        //не променяй на abstract. Не всеки метод е нужно да се пренаписва във всеки клас
        public virtual void Move(int dx, int dy)
        {
            Position = new Point(Position.X + dx, Position.Y + dy);
        }
        public virtual void Resize(int dx, int dy)
        {
            Width = Math.Max(10, Width + dx);
            Height = Math.Max(10, Height + dy);
        }

        public virtual bool MouseOnResizeHandle(Point p)
        {
            Rectangle handleRect = new Rectangle(Position.X + Width - handleSize,
                Position.Y + Height - handleSize, handleSize, handleSize);
            return handleRect.Contains(p);
        }

        //по този начин задължаваме класовете да имплементират Clone
        public abstract IShape CloneShape();
    }
}
