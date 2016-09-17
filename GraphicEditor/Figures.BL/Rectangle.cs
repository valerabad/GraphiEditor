using System.Drawing;

namespace Figures.BL
{
    public class Rectangle : Shapes
    {    
        SolidBrush brush;
        public override Bitmap Draw(Point p1, Point p2, Color color)
        {                      
            pen.Color = color;            
            graph = Graphics.FromImage(bmp);
            graph.DrawRectangle(pen, p1.X, p1.Y, p2.X, p2.Y);
            graph.FillRectangle(brush, new System.Drawing.Rectangle(p1.X, p1.Y, p2.X, p2.Y));            
            return bmp;
        }

        public Rectangle(Color backgroundColor)
        {
            pen = new Pen(Color.Black);
            pen.Width = 5;
            brush = new SolidBrush(backgroundColor);          
        }

    }
}
