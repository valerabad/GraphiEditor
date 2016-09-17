using System.Drawing;

namespace Figures.BL
{
    public class Picture
    {
        static protected Graphics graph;
        static public Bitmap bmp;
        public static void clearPicture()
        {
            graph.Clear(Color.Transparent);            
        }

    }
}
