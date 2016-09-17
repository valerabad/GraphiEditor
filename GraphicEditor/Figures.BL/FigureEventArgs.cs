using System;
using System.Drawing;

namespace Figures.BL
{
    public class FigureEventArgs : EventArgs
    {
        public Color color;
        public Location loc;
        public Pen pen;

        public FigureEventArgs(Color color, Location loc, Pen pen)
        {
            this.color = color;
            this.loc = loc;
            this.pen = pen;

        }
    }
}