using System.Drawing;

namespace Figures.BL
{
    public class Circle : Shapes
    {
        SolidBrush brush;
        public override Bitmap Draw(Point p1, Point p2, Color color)
        {
            pen.Color = color;
            graph = Graphics.FromImage(bmp);
            graph.DrawEllipse(pen, p1.X, p1.Y, p2.X, p2.Y);
            graph.FillEllipse(brush, new System.Drawing.Rectangle(p1.X, p1.Y, p2.X, p2.Y));
            return bmp;
        }

        public Circle(Color backgroundColor)
        {
            pen = new Pen(Color.Black);
            pen.Width = 5;
            brush = new SolidBrush(backgroundColor);
        }
    }
}
