using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicEditor
{
    public interface IView
    {
        PictureBox pictureBox { get; }
        int point_1_x { get; }
        int point_1_Y { get; }
        int point_2_x { get; }
        int point_2_Y { get; }
        Color selectedColor { get; }
        Color background_Color { get; }
        string fileName { get; }
        Point PrevPoint { get; set; }
        Point CurrentPoint { get; set; }
        void Invoke();
        Button invertButton { get; }
    }
}
