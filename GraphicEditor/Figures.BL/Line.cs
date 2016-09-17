using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
//using System.Windows.Forms;

namespace Figures.BL
{
    public class Line : Shapes
    {
        //public event EventHandler<FigureEventArgs> Drawing;
        //public void OnDraw(FigureEventArgs args)
        //{
        //    if (Drawing != null)
        //        Drawing(this, args);          
        //}

        public Line()
        {
            pen = new Pen(Color.Black);
            p1 = new Point(10, 10);
            p2 = new Point(50, 50);
            //bmp1 = new Bitmap(bmp);
        }
       
        public override Bitmap Draw(Point p1, Point p2, Color color)
        {
            pen.Color = color;
            graph = Graphics.FromImage(bmp);
            graph.DrawLine(pen,p1, p2);
            return bmp;
        }

        //public override Bitmap Draw(Bitmap bmp)
        //{
        //    pen.Color = Color.Blue;
        //    graph = Graphics.FromImage(bmp);
        //    graph.DrawLine(pen, p1, p2);
        //    return bmp;
        //}

        //public override Bitmap  LoadPicture(string fileName)
        //{
        //    bmp1 = new Bitmap(fileName);
        //    graph = Graphics.FromImage(bmp1);   
        //    return bmp1;
        //}

    }
}
