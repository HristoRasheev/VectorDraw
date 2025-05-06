using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDraw.Models
{
    public interface IShape
    {
        abstract void Draw(Graphics g);
        abstract bool Contains(Point p);
        abstract double GetArea();
        abstract void Move(int dx, int dy);
        abstract void Resize(int dx, int dy);
        IShape CloneShape();
    }
}
