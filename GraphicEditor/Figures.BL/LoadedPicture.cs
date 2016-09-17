using System.Drawing;

namespace Figures.BL
{
    public class LoadedPicture : Picture
    {
        public Bitmap showPicture(string fileName)
        {
            bmp = new Bitmap(fileName);
            graph = Graphics.FromImage(bmp);
            return bmp;
        }
   
        
    }
}
