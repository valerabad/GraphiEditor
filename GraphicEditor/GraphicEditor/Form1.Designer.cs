namespace GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clear_button = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Save_button = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Point1 = new System.Windows.Forms.Label();
            this.label_Point2 = new System.Windows.Forms.Label();
            this.UpDown_Point1_X = new System.Windows.Forms.NumericUpDown();
            this.UpDown_Point1_Y = new System.Windows.Forms.NumericUpDown();
            this.UpDown_Point2_X = new System.Windows.Forms.NumericUpDown();
            this.UpDown_Point2_Y = new System.Windows.Forms.NumericUpDown();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.SelectFigure_button = new System.Windows.Forms.Button();
            this.selectColor_button_ = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label_selectColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point1_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point1_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point2_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point2_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(439, 243);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(106, 24);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_buttonClick);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(439, 284);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(106, 29);
            this.Save_button.TabIndex = 6;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(297, 281);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(106, 29);
            this.Load_button.TabIndex = 7;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(297, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 162);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(81, 8);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(14, 13);
            this.label_X.TabIndex = 17;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(159, 8);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(14, 13);
            this.label_Y.TabIndex = 18;
            this.label_Y.Text = "Y";
            // 
            // label_Point1
            // 
            this.label_Point1.AutoSize = true;
            this.label_Point1.Location = new System.Drawing.Point(21, 34);
            this.label_Point1.Name = "label_Point1";
            this.label_Point1.Size = new System.Drawing.Size(40, 13);
            this.label_Point1.TabIndex = 20;
            this.label_Point1.Text = "Point 1";
            // 
            // label_Point2
            // 
            this.label_Point2.AutoSize = true;
            this.label_Point2.Location = new System.Drawing.Point(21, 69);
            this.label_Point2.Name = "label_Point2";
            this.label_Point2.Size = new System.Drawing.Size(40, 13);
            this.label_Point2.TabIndex = 21;
            this.label_Point2.Text = "Point 2";
            // 
            // UpDown_Point1_X
            // 
            this.UpDown_Point1_X.Location = new System.Drawing.Point(67, 32);
            this.UpDown_Point1_X.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.UpDown_Point1_X.Name = "UpDown_Point1_X";
            this.UpDown_Point1_X.Size = new System.Drawing.Size(67, 20);
            this.UpDown_Point1_X.TabIndex = 23;
            this.UpDown_Point1_X.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // UpDown_Point1_Y
            // 
            this.UpDown_Point1_Y.Location = new System.Drawing.Point(136, 32);
            this.UpDown_Point1_Y.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.UpDown_Point1_Y.Name = "UpDown_Point1_Y";
            this.UpDown_Point1_Y.Size = new System.Drawing.Size(67, 20);
            this.UpDown_Point1_Y.TabIndex = 24;
            this.UpDown_Point1_Y.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // UpDown_Point2_X
            // 
            this.UpDown_Point2_X.Location = new System.Drawing.Point(65, 67);
            this.UpDown_Point2_X.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.UpDown_Point2_X.Name = "UpDown_Point2_X";
            this.UpDown_Point2_X.Size = new System.Drawing.Size(67, 20);
            this.UpDown_Point2_X.TabIndex = 25;
            this.UpDown_Point2_X.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // UpDown_Point2_Y
            // 
            this.UpDown_Point2_Y.Location = new System.Drawing.Point(136, 67);
            this.UpDown_Point2_Y.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.UpDown_Point2_Y.Name = "UpDown_Point2_Y";
            this.UpDown_Point2_Y.Size = new System.Drawing.Size(67, 20);
            this.UpDown_Point2_Y.TabIndex = 26;
            this.UpDown_Point2_Y.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(303, 243);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(100, 23);
            this.buttonInvert.TabIndex = 28;
            this.buttonInvert.Text = "Invert";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select figure";
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Items.AddRange(new object[] {
            "Line",
            "Rectangle",
            "Circle"});
            this.comboBoxFigures.Location = new System.Drawing.Point(11, 160);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigures.TabIndex = 34;
            this.comboBoxFigures.Text = "Rectangle";
            // 
            // SelectFigure_button
            // 
            this.SelectFigure_button.Location = new System.Drawing.Point(84, 130);
            this.SelectFigure_button.Name = "SelectFigure_button";
            this.SelectFigure_button.Size = new System.Drawing.Size(50, 24);
            this.SelectFigure_button.TabIndex = 35;
            this.SelectFigure_button.Text = "Draw";
            this.SelectFigure_button.UseVisualStyleBackColor = true;
            this.SelectFigure_button.Click += new System.EventHandler(this.SelectFigure_button_Click);
            // 
            // selectColor_button_
            // 
            this.selectColor_button_.Location = new System.Drawing.Point(11, 100);
            this.selectColor_button_.Name = "selectColor_button_";
            this.selectColor_button_.Size = new System.Drawing.Size(121, 26);
            this.selectColor_button_.TabIndex = 3;
            this.selectColor_button_.Text = "Select color for line";
            this.selectColor_button_.UseVisualStyleBackColor = true;
            this.selectColor_button_.Click += new System.EventHandler(this.selectColor_button_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(139, 160);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(146, 21);
            this.comboBoxColor.TabIndex = 3;
            this.comboBoxColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            this.comboBoxColor.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label_selectColor
            // 
            this.label_selectColor.AutoSize = true;
            this.label_selectColor.Location = new System.Drawing.Point(140, 134);
            this.label_selectColor.Name = "label_selectColor";
            this.label_selectColor.Size = new System.Drawing.Size(138, 13);
            this.label_selectColor.TabIndex = 30;
            this.label_selectColor.Text = "Select color for background";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 403);
            this.Controls.Add(this.SelectFigure_button);
            this.Controls.Add(this.comboBoxFigures);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_selectColor);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.UpDown_Point2_Y);
            this.Controls.Add(this.UpDown_Point2_X);
            this.Controls.Add(this.UpDown_Point1_Y);
            this.Controls.Add(this.UpDown_Point1_X);
            this.Controls.Add(this.label_Point2);
            this.Controls.Add(this.label_Point1);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.selectColor_button_);
            this.Name = "Form1";
            this.Text = "Graphic editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point1_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point1_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point2_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Point2_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion           
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Point1;
        private System.Windows.Forms.Label label_Point2;
        private System.Windows.Forms.NumericUpDown UpDown_Point1_X;
        private System.Windows.Forms.NumericUpDown UpDown_Point1_Y;
        private System.Windows.Forms.NumericUpDown UpDown_Point2_X;
        private System.Windows.Forms.NumericUpDown UpDown_Point2_Y;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFigures;
        private System.Windows.Forms.Button SelectFigure_button;
        private System.Windows.Forms.Button selectColor_button_;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label_selectColor;
    }
}

