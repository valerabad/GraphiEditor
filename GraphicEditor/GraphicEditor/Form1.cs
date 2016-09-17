using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class Form1 : Form, IView
    {
        Color lineColor;
        Color backgroundColor;
        private readonly Presenter presenter = new Presenter();       
        bool isPresed = false;

        #region implementation of the forms interface

        public Button invertButton
        {
            get { return buttonInvert; }
        }

        public Point PrevPoint
        {
            get; set;
        }
        
        public Point CurrentPoint { get; set; }

        public string fileName
        {
            get; set;
        }

        public Color selectedColor
        {
            get { return this.lineColor; }                    
        }

        public Color  background_Color 
        {
            get { return this.backgroundColor; }
        }

        public PictureBox pictureBox
        {
            get { return pictureBox1; }
        }

        public int point_1_x
        {
            get
            {
                int point = Convert.ToInt16(UpDown_Point1_X.Text);
                return point;
            }
        }
                
        public int point_1_Y
        {
            get { return Convert.ToInt16(UpDown_Point1_Y.Text); }
        }
        public int point_2_x
        {
            get { return Convert.ToInt16(UpDown_Point2_X.Text); }
        }
        public int point_2_Y
        {
            get { return Convert.ToInt16(UpDown_Point2_Y.Text); }
        }
        #endregion        

        public Form1()
        {
            InitializeComponent();            
                                  
            lineColor = Color.Black;
            backgroundColor = Color.White;
            presenter.View = this;
            presenter.Initialize();
            comboBoxColor.Items.AddRange(Enum.GetNames(typeof(KnownColor)));            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            presenter.Initialize();
        }

        private void Load_button_Click(object sender, EventArgs e)
        {                                     
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = openFileDialog1.FileName;
                    presenter.LoadFile();                   
                } 
                catch (Exception ex)
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл "+ ex,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {                             
                saveFileDialog.Title = "Сохранить картинку как...";                
                saveFileDialog.OverwritePrompt = true;                
                saveFileDialog.CheckPathExists = true;                
                saveFileDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        fileName = saveFileDialog.FileName;
                        presenter.Save();                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Невозможно сохранить изображение:" + ex, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }            
        }                                               

        private void selectColor_button_Click(object sender, EventArgs e)
        {                       
            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
                lineColor = colorDialog1.Color;
            else lineColor = Color.Black;
        }

        private void clear_buttonClick(object sender, EventArgs e)
        {           
            //if (Thread.CurrentThread.IsBackground)
                //Thread.CurrentThread.Abort();
            presenter.Clear_();
        }

        #region for random drawing  

        private void for_paint()
        {
            presenter.RandomDrawing();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPresed)
            {
                PrevPoint = CurrentPoint;
                CurrentPoint = e.Location;
                for_paint();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isPresed = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPresed = true;
            CurrentPoint = e.Location;
        }
        #endregion        

        // for color list
        #region
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.FillRectangle(new SolidBrush(Color.White), rect.X, rect.Y, rect.Width, rect.Height); //
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Top);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 15, rect.Height - 5);
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.comboBoxColor.Items.Add(c.Name);
            }
        }
        #endregion

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {                       
            backgroundColor = Color.FromName(comboBoxColor.SelectedItem.ToString());
        }               

        public void Invert()
        {
            presenter.invertPict();            
            Thread.CurrentThread.Abort();            
        }

        public void Invoke()
        {
            Invoke((MethodInvoker)
                        delegate
                        {
                            pictureBox.Refresh();
                            //listBox1.Items.Add(Thread.CurrentThread.ThreadState);
                            //listBox1.Items.Add(Thread.CurrentThread.Name);
                        });            
        }        

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            
            Thread th = new Thread(new ThreadStart(Invert));
            th.Name = "myStream";
            th.IsBackground = true;            
            th.Start();
            //new Thread(Start) { IsBackground = true }.Start();           
        }

        private void SelectFigure_button_Click(object sender, EventArgs e)
        {
            presenter.SelectFigure(comboBoxFigures.Text);
        }
    }
}
