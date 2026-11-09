
using System;
using System.Drawing;

namespace shape2
{
    public class Circle : Shape
    {
        public Circle(Point start, Point end, Color color)
            : base(start, end, color) { }

        public override void Draw(Graphics g)
        {
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int w = Math.Abs(EndPoint.X - StartPoint.X);
            int h = Math.Abs(EndPoint.Y - StartPoint.Y);

            using (Pen p = new Pen(ShapeColor, 3))
                g.DrawEllipse(p, x, y, w, h);
        }
    }
}
