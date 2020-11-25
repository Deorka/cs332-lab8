namespace Affine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.light_z = new System.Windows.Forms.TextBox();
            this.light_y = new System.Windows.Forms.TextBox();
            this.light_x = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.camPosX = new System.Windows.Forms.NumericUpDown();
            this.camPosY = new System.Windows.Forms.NumericUpDown();
            this.camPosZ = new System.Windows.Forms.NumericUpDown();
            this.camDirX = new System.Windows.Forms.NumericUpDown();
            this.camDirY = new System.Windows.Forms.NumericUpDown();
            this.camDirZ = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDirX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDirY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDirZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(845, 58);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(845, 84);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown2.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(845, 110);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Смещение";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(749, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Преобразовать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тетраэдр",
            "Гексаэдр",
            "Октаэдр",
            "Икосаэдр",
            "Додекаэдр"});
            this.comboBox1.Location = new System.Drawing.Point(768, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Фигура";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Поворот";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Угол по оси OX";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(845, 139);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Угол по оси OY";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(845, 165);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown5.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(753, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Угол по оси OZ";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(845, 191);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown6.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(948, 31);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "Алгоритм";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Отсечение нелицевых граней",
            "Алгоритм Z-буфера"});
            this.comboBox5.Location = new System.Drawing.Point(1029, 31);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(140, 21);
            this.comboBox5.TabIndex = 54;
            this.comboBox5.Text = "Отсечение нелицевых граней";
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1029, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 24);
            this.button7.TabIndex = 93;
            this.button7.Text = "Построить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // light_z
            // 
            this.light_z.Location = new System.Drawing.Point(1125, 110);
            this.light_z.Margin = new System.Windows.Forms.Padding(2);
            this.light_z.Name = "light_z";
            this.light_z.ReadOnly = true;
            this.light_z.Size = new System.Drawing.Size(44, 20);
            this.light_z.TabIndex = 97;
            this.light_z.Text = "300";
            // 
            // light_y
            // 
            this.light_y.Location = new System.Drawing.Point(1077, 110);
            this.light_y.Margin = new System.Windows.Forms.Padding(2);
            this.light_y.Name = "light_y";
            this.light_y.ReadOnly = true;
            this.light_y.Size = new System.Drawing.Size(44, 20);
            this.light_y.TabIndex = 96;
            this.light_y.Text = "0";
            // 
            // light_x
            // 
            this.light_x.Location = new System.Drawing.Point(1029, 110);
            this.light_x.Margin = new System.Windows.Forms.Padding(2);
            this.light_x.Name = "light_x";
            this.light_x.ReadOnly = true;
            this.light_x.Size = new System.Drawing.Size(44, 20);
            this.light_x.TabIndex = 95;
            this.light_x.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(948, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 94;
            this.label14.Text = "Источник освещения:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(678, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Камера";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(899, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 99;
            this.label11.Text = "Позиция";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(899, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "Направление";
            // 
            // camPosX
            // 
            this.camPosX.Location = new System.Drawing.Point(980, 271);
            this.camPosX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.camPosX.Name = "camPosX";
            this.camPosX.Size = new System.Drawing.Size(44, 20);
            this.camPosX.TabIndex = 101;
            this.camPosX.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.camPosX.ValueChanged += new System.EventHandler(this.camPosX_ValueChanged);
            // 
            // camPosY
            // 
            this.camPosY.Location = new System.Drawing.Point(1030, 271);
            this.camPosY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.camPosY.Name = "camPosY";
            this.camPosY.Size = new System.Drawing.Size(44, 20);
            this.camPosY.TabIndex = 102;
            this.camPosY.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.camPosY.ValueChanged += new System.EventHandler(this.camPosY_ValueChanged);
            // 
            // camPosZ
            // 
            this.camPosZ.Location = new System.Drawing.Point(1080, 271);
            this.camPosZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.camPosZ.Name = "camPosZ";
            this.camPosZ.Size = new System.Drawing.Size(44, 20);
            this.camPosZ.TabIndex = 103;
            this.camPosZ.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.camPosZ.ValueChanged += new System.EventHandler(this.camPosZ_ValueChanged);
            // 
            // camDirX
            // 
            this.camDirX.Location = new System.Drawing.Point(980, 300);
            this.camDirX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.camDirX.Name = "camDirX";
            this.camDirX.Size = new System.Drawing.Size(44, 20);
            this.camDirX.TabIndex = 104;
            this.camDirX.ValueChanged += new System.EventHandler(this.camDirX_ValueChanged);
            // 
            // camDirY
            // 
            this.camDirY.Location = new System.Drawing.Point(1030, 300);
            this.camDirY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.camDirY.Name = "camDirY";
            this.camDirY.Size = new System.Drawing.Size(44, 20);
            this.camDirY.TabIndex = 105;
            this.camDirY.ValueChanged += new System.EventHandler(this.camDirY_ValueChanged);
            // 
            // camDirZ
            // 
            this.camDirZ.Location = new System.Drawing.Point(1080, 300);
            this.camDirZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.camDirZ.Name = "camDirZ";
            this.camDirZ.Size = new System.Drawing.Size(44, 20);
            this.camDirZ.TabIndex = 106;
            this.camDirZ.ValueChanged += new System.EventHandler(this.camDirZ_ValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Перспективная",
            "Параллельная"});
            this.comboBox2.Location = new System.Drawing.Point(741, 299);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(144, 21);
            this.comboBox2.TabIndex = 107;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(678, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 108;
            this.label13.Text = "Проекция";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(681, 329);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(558, 364);
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1166, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 110;
            this.label15.Text = "label15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 701);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.camDirZ);
            this.Controls.Add(this.camDirY);
            this.Controls.Add(this.camDirX);
            this.Controls.Add(this.camPosZ);
            this.Controls.Add(this.camPosY);
            this.Controls.Add(this.camPosX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.light_z);
            this.Controls.Add(this.light_y);
            this.Controls.Add(this.light_x);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDirX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDirY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camDirZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox light_z;
        private System.Windows.Forms.TextBox light_y;
        private System.Windows.Forms.TextBox light_x;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown camPosX;
        private System.Windows.Forms.NumericUpDown camPosY;
        private System.Windows.Forms.NumericUpDown camPosZ;
        private System.Windows.Forms.NumericUpDown camDirX;
        private System.Windows.Forms.NumericUpDown camDirY;
        private System.Windows.Forms.NumericUpDown camDirZ;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
    }
}

