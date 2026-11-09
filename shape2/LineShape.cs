
using System.Drawing;

namespace shape2
{
    public class LineShape : Shape
    {
        public LineShape(Point start, Point end, Color color)
            : base(start, end, color) { }

        public override void Draw(Graphics g)
        {
            using (Pen p = new Pen(ShapeColor, 3))
                g.DrawLine(p, StartPoint, EndPoint);
        }
    }
}
