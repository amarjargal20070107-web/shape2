
using System.Drawing;

namespace shape2
{
    public abstract class Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color ShapeColor { get; set; }

        public Shape(Point start, Point end, Color color)
        {
            StartPoint = start;
            EndPoint = end;
            ShapeColor = color;
        }

        public abstract void Draw(Graphics g);
    }
}
