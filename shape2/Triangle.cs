
using System;
using System.Drawing;

namespace shape2
{
    public class Triangle : Shape
    {
        public Triangle(Point start, Point end, Color color)
            : base(start, end, color) { }

        public override void Draw(Graphics g)
        {
            Point[] points =
            {
                new Point((StartPoint.X + EndPoint.X) / 2,
                    Math.Min(StartPoint.Y, EndPoint.Y)),

                new Point(Math.Min(StartPoint.X, EndPoint.X),
                    Math.Max(StartPoint.Y, EndPoint.Y)),

                new Point(Math.Max(StartPoint.X, EndPoint.X),
                    Math.Max(StartPoint.Y, EndPoint.Y))
            };

            using (Pen p = new Pen(ShapeColor, 3))
                g.DrawPolygon(p, points);
        }
    }
}
