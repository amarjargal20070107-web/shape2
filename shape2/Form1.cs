
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace shape2
{
    public partial class Form1 : Form
    {
        private Bitmap canvas = new Bitmap(1, 1);

        private bool zurjBaina = false;
        private Point ehlelTseg;
        private Point suuliinTseg;

        private Color songosonUnguu = Color.Black;
        private Pen uzeg = new Pen(Color.Black, 3);

        // Зурсан дүрсүүдийг хадгалах жагсаалт
        private List<Shape> shapes = new List<Shape>();

        // Одоогоор сонгосон дүрс
        private string songosonDurs = "Free";

        // Чирж байх үеийн түр дүрс
        private Shape turDurs = null;

        public Form1()
        {
            InitializeComponent();

            canvas.Dispose();
            canvas = new Bitmap(
                Math.Max(DrawingPanel.Width, 1),
                Math.Max(DrawingPanel.Height, 1));

            DrawingPanel.BackColor = Color.White;

            DrawingPanel.MouseDown += DrawingPanel_MouseDown;
            DrawingPanel.MouseMove += DrawingPanel_MouseMove;
            DrawingPanel.MouseUp += DrawingPanel_MouseUp;
            DrawingPanel.Paint += DrawingPanel_Paint;

            // Зураасны хэмжээ
            cmbSize.Items.Clear();
            cmbSize.Items.AddRange(
                new object[] { "1", "3", "5", "8", "12", "20" });

            cmbSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSize.SelectedItem = "3";

            cmbSize.SelectedIndexChanged += cmbSize_SelectedIndexChanged;

            btnPen.Click += btnPen_Click;
            btnEraser.Click += btnEraser_Click;
            btnColor.Click += btnColor_Click;

            // Shape цэсний сонголтууд
            rectangleToolStripMenuItem.Click +=
                (s, e) => songosonDurs = "Rectangle";

            triangleToolStripMenuItem.Click +=
                (s, e) => songosonDurs = "Triangle";

            circleToolStripMenuItem.Click +=
                (s, e) => songosonDurs = "Circle";

            lineToolStripMenuItem.Click +=
                (s, e) => songosonDurs = "Line";
        }

        // Бүх зураг болон дүрсийг дэлгэцэнд гаргах
        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(canvas, 0, 0);

            foreach (Shape shape in shapes)
                shape.Draw(e.Graphics);

            if (turDurs != null)
                turDurs.Draw(e.Graphics);
        }

        // Хулгана дарах
        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            zurjBaina = true;
            ehlelTseg = e.Location;
            suuliinTseg = e.Location;

            if (songosonDurs == "Free")
            {
                using (Graphics g = Graphics.FromImage(canvas))
                using (Brush brush = new SolidBrush(uzeg.Color))
                {
                    float r = uzeg.Width / 2f;

                    g.FillEllipse(
                        brush,
                        e.X - r,
                        e.Y - r,
                        uzeg.Width,
                        uzeg.Width);
                }
            }
        }

        // Хулгана чирэх
        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!zurjBaina)
                return;

            suuliinTseg = e.Location;

            if (songosonDurs == "Free")
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.DrawLine(uzeg, ehlelTseg, e.Location);
                }

                ehlelTseg = e.Location;
            }
            else
            {
                turDurs = CreateShape(
                    ehlelTseg,
                    suuliinTseg,
                    songosonUnguu);

            }

            DrawingPanel.Invalidate();
        }

        // Хулгана тавих
        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (!zurjBaina)
                return;

            suuliinTseg = e.Location;

            if (songosonDurs != "Free")
            {
                Shape newShape = CreateShape(
                    ehlelTseg,
                    suuliinTseg,
                    songosonUnguu);

                if (newShape != null)
                    shapes.Add(newShape);
            }

            turDurs = null;
            zurjBaina = false;

            DrawingPanel.Invalidate();
        }

        // Сонгосон төрлөөр дүрс үүсгэх
        private Shape CreateShape(
            Point start, Point end, Color color)
        {
            switch (songosonDurs)
            {
                case "Circle":
                    return new Circle(start, end, color);

                case "Rectangle":
                    return new RectangleShape(start, end, color);

                case "Triangle":
                    return new Triangle(start, end, color);

                case "Line":
                    return new LineShape(start, end, color);

                default:
                    return null;
            }
        }

        // Үзэг сонгох
        private void btnPen_Click(object sender, EventArgs e)
        {
            songosonDurs = "Free";
            uzeg.Color = songosonUnguu;
        }

        // Баллуур
        private void btnEraser_Click(object sender, EventArgs e)
        {
            songosonDurs = "Free";
            uzeg.Color = Color.White;
        }

        // Өнгө сонгох
        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                cd.Color = songosonUnguu;

                if (cd.ShowDialog() == DialogResult.OK)
                {
                    songosonUnguu = cd.Color;
                    uzeg.Color = songosonUnguu;
                }
            }
        }

        // Зураасны хэмжээ
        private void cmbSize_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (int.TryParse(
                cmbSize.SelectedItem?.ToString(), out int size))
            {
                uzeg.Width = size;
            }
        }

        // Зургийг бүхэлд нь цэвэрлэх
        private void ClearCanvas()
        {
            using (Graphics g = Graphics.FromImage(canvas))
                g.Clear(Color.White);

            shapes.Clear();
            turDurs = null;
            DrawingPanel.Invalidate();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            canvas.Dispose();
            uzeg.Dispose();

            base.OnFormClosed(e);
        }
    }
}
