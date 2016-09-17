using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Figures.BL
{
    public abstract class Shapes : Picture
    {
        string name { get; set; }
        public Color color { get; set; }
        public Pen pen;
        //protected Graphics graph;
        //static protected Bitmap bmp1;
        public Location loc;
        public Point p1,p2;

        public abstract Bitmap Draw(Point p1, Point p2, Color color);

        //public abstract Bitmap Draw(Bitmap bmp);    
        //abstract public Bitmap LoadPicture(string fileName);        

        public static void CreateBMP(Bitmap bmp_)
        {
            bmp = bmp_;    
        }
    }
    
    public struct Location
    {
        public Point point1;
        public Point point2;
    }

    
}
