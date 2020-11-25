using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Windows.Forms;

namespace Affine
{

    public enum Axis { AXIS_X, AXIS_Y, AXIS_Z, LINE };
    public enum Projection { PERSPECTIVE = 0, ISOMETRIC, ORTHOGR_X, ORTHOGR_Y, ORTHOGR_Z };
    public enum Clipping { Clipp = 0, ZBuffer, Gouraud, Texture, Graph};

    public partial class Form1 : Form
    {
        Graphics g;
        Projection projection = 0;
        Axis rotateLineMode = 0;
        Polyhedron figure = null;
        int revertId = -1;

        Clipping clipping = 0;

        Camera camera = new Camera(50,50);

        Color fill_color = Color.Red;
        byte[] rgbValuesTexture; // для картинок и текстуры
        Bitmap texture;
        public Bitmap bmp;
        BitmapData bmpDataTexture; // для картинок и текстуры
        byte[] rgbValues;
        public BitmapData bmpData;
        public IntPtr ptr; // указатель на rgbValues
        public int bytes; // длина rgbValues

        Graphic Graph = null;

        // CAM
        Graphics gc;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            g.TranslateTransform(pictureBox1.ClientSize.Width / 2, pictureBox1.ClientSize.Height / 2);
            g.ScaleTransform(1, -1);


            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = pictureBox1.CreateGraphics();
            g.TranslateTransform(pictureBox1.ClientSize.Width / 2, pictureBox1.ClientSize.Height / 2);
            g.ScaleTransform(1, -1);



            texture = Image.FromFile("../../texture1.jpg") as Bitmap;
            Rectangle rectTexture = new Rectangle(0, 0, texture.Width, texture.Height);
            bmpDataTexture = texture.LockBits(rectTexture, ImageLockMode.ReadWrite, texture.PixelFormat);
            int bytesTexture = Math.Abs(bmpDataTexture.Stride) * texture.Height;
            rgbValuesTexture = new byte[bytesTexture];
            System.Runtime.InteropServices.Marshal.Copy(bmpDataTexture.Scan0, rgbValuesTexture, 0, bytesTexture);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            // CAM
            gc = pictureBox2.CreateGraphics();
            gc.TranslateTransform(pictureBox2.ClientSize.Width / 2, pictureBox2.ClientSize.Height / 2);
            gc.ScaleTransform(1, -1);
        }

        // CAM
        private void camRender()
        {
            if (figure == null)
            {
                MessageBox.Show("Неодбходимо выбрать фигуру!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            Polyhedron camFigure = new Polyhedron(figure.Polygons);
            gc.Clear(Color.White);
            Projection camProjection = (Projection)comboBox2.SelectedIndex;
            // rotation
            Point3D camPosition = new Point3D(
                (float)camPosX.Value,
                (float)camPosY.Value,
                (float)camPosZ.Value
            );
            Point3D camTarget = new Point3D(
                (float)camDirX.Value,
                (float)camDirY.Value,
                (float)camDirZ.Value
            );
            double OZ = toDegree(camTarget.Y, camTarget.X, camPosition.Y, camPosition.X);
            camFigure.Rotate(OZ, Axis.AXIS_Z);
            camFigure.reflectX();
            camFigure.reflectY();
            float distZ = (float)Math.Sqrt(Math.Pow(camPosition.X - camTarget.X, 2) + Math.Pow(camPosition.Y - camTarget.Y, 2));
            double OX = toDegree(0, 0, distZ, camPosition.Z - camTarget.Z);
            camFigure.Rotate(270 + OX, Axis.AXIS_X);
            label15.Text = OX.ToString();
            // shift
            camFigure.Translate(camTarget.X, camTarget.Y, -camTarget.Z);
            double distance = Math.Sqrt(Math.Pow(camPosition.X - camTarget.X, 2) + Math.Pow(camPosition.Y - camTarget.Y, 2) + Math.Pow(camPosition.Z - camTarget.Z, 2));
            float scaleIndex = 50 / (float)distance;
            camFigure.Scale(scaleIndex, scaleIndex, scaleIndex);
            camFigure.Show(gc, camProjection);
        }

        private double toDegree(float x0, float y0, float x1, float y1) {
            double relX = x1 - x0;
            double relY = y1 - y0;
            double deg;
            if (relX < 0) deg = Math.Atan(relY / relX) * 180 / Math.PI + 180;
            else if (relY < 0) deg = Math.Atan(relY / relX) * 180 / Math.PI + 360;
            else deg = Math.Atan(relY / relX) * 180 / Math.PI;
            return deg;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (figure == null)
            {
                MessageBox.Show("Неодбходимо выбрать фигуру!", "Ошибка!", MessageBoxButtons.OK);
            }
            else
            {
                //перемещение
                int offsetX = (int)numericUpDown1.Value, offsetY = (int)numericUpDown2.Value, offsetZ = (int)numericUpDown3.Value;
                figure.Translate(offsetX, offsetY, offsetZ);
                
                //поворот
                int rotateAngleX = (int)numericUpDown4.Value;
                figure.Rotate(rotateAngleX, 0);

                int rotateAngleY = (int)numericUpDown5.Value;
                figure.Rotate(rotateAngleY, Axis.AXIS_Y);

                int rotateAngleZ = (int)numericUpDown6.Value;
                figure.Rotate(rotateAngleZ, Axis.AXIS_Z);
            }

            g.Clear(Color.White);
            if (clipping == 0)
                figure.Show(g, projection);
            else if (clipping == Clipping.Gouraud)
                show_gouraud();
            else if (clipping == Clipping.ZBuffer)
                show_z_buff();
            else if (clipping == Clipping.Texture)
                show_texture();

            camera.show(g, projection);
            camRender();
        }

        //Рисование фигуры
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //Татраэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Tetrahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    else if (clipping == Clipping.ZBuffer)
                        show_z_buff();
                    break;
                case 1:
                    //Гексаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Hexahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    else if (clipping == Clipping.ZBuffer)
                        show_z_buff();
                    break;
                case 2:
                    //Октаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Octahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    else if (clipping == Clipping.ZBuffer)
                        show_z_buff();
                    break;
                case 3:
                    //Икосаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Icosahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    else if (clipping == Clipping.ZBuffer)
                        show_z_buff();
                    break;
                case 4:
                    //Додекаэдр
                    g.Clear(Color.White);
                    figure = new Polyhedron();
                    figure.Dodecahedron();
                    if (clipping == 0)
                        figure.Show(g, projection);
                    else if (clipping == Clipping.ZBuffer)
                        show_z_buff();
                    break;
                default:
                    break;
            }
            camRender();
        }

        //поворот вокруг линии
        private void RotateAroundLine()
        {
            Edge rotateLine = new Edge(
                                new Point3D(
                                    0,
                                    0,
                                    0),
                                new Point3D(
                                    0,
                                    0,
                                    0));

            float Ax = rotateLine.First.X, Ay = rotateLine.First.Y, Az = rotateLine.First.Z;
            figure.Translate(-Ax, -Ay, -Az);

            figure.Translate(Ax, Ay, Az);

            g.Clear(Color.White);
            if (clipping == 0)
                figure.Show(g, projection);
            else if (clipping == Clipping.Gouraud)
                show_gouraud();
            else if (clipping == Clipping.ZBuffer)
                show_z_buff();
            else if (clipping == Clipping.Texture)
                show_texture();

            camera.show(g, projection);
        }

        //отображение света
        private void button1_Click_1(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            if (figure != null)
                if (clipping == 0)
                    figure.Show(g, projection);
                else if (clipping == Clipping.ZBuffer)
                    show_z_buff();

            camera.show(g, projection);
        }

        //поворот
        private void button3_Click(object sender, EventArgs e)
        {
            if (revertId == 0)
            {
                figure.reflectX();
                g.Clear(Color.White);
                if (clipping == 0)
                    figure.Show(g, projection);
                else if (clipping == Clipping.ZBuffer)
                    show_z_buff();
            }
            else if (revertId == 1)
            {
                figure.reflectY();
                g.Clear(Color.White);
                if (clipping == 0)
                    figure.Show(g, projection);
                else if (clipping == Clipping.ZBuffer)
                    show_z_buff();
            }
            else if (revertId == 2)
            {
                figure.reflectZ();
                g.Clear(Color.White);
                if (clipping == 0)
                    figure.Show(g, projection);
                else if (clipping == Clipping.ZBuffer)
                    show_z_buff();
            }
        }

        //INVOKE ROTATE AROUND LINE
        private void button4_Click(object sender, EventArgs e) => RotateAroundLine();

        //CLIPPING
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    clipping = 0;
                    break;
                case 1:
                    clipping = Clipping.ZBuffer;
                    break;
                case 2:
                    clipping = Clipping.Gouraud;
                    break;
                case 3:
                    clipping = Clipping.Texture;
                    break;
                default:
                    clipping = 0;
                    break;
            }
        }

        //Z-BUFFER
        private void show_z_buff()
        {
            int[] buff = new int[pictureBox1.Width * pictureBox1.Height];
            int[] colors = new int[pictureBox1.Width * pictureBox1.Height];

            figure.calculateZBuffer(camera.view, pictureBox1.Width, pictureBox1.Height, out buff, out colors);

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;

            g.Clear(Color.White);

            for (int i = 0; i < pictureBox1.Width; ++i)
                for (int j = 0; j < pictureBox1.Height; ++j)
                {
                    Color c = Color.FromArgb(buff[i * pictureBox1.Height + j], buff[i * pictureBox1.Height + j], buff[i * pictureBox1.Height + j]);
                    bmp.SetPixel(i, j, c);
                }

            pictureBox1.Refresh();
        }

        //GOURAUD
        private void show_gouraud()
        {
            float[] intensive = new float[pictureBox1.Width * pictureBox1.Height];

            figure.calc_gouraud(camera.view, pictureBox1.Width, pictureBox1.Height, out intensive, new Point3D(int.Parse(light_x.Text), int.Parse(light_y.Text), int.Parse(light_z.Text)));
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g.Clear(Color.White);

            for (int i = 0; i < pictureBox1.Width; ++i)
                for (int j = 0; j < pictureBox1.Height; ++j)
                {
                    Color c;
                    if (intensive[i * pictureBox1.Height + j] < 1E-6f)
                        c = Color.White;
                    else
                    {
                        float intsv = intensive[i * pictureBox1.Height + j];
                        if (intsv > 1)
                            intsv = 1;
                        c = Color.FromArgb((int)(fill_color.R * intsv) % 256, (int)(fill_color.G * intsv) % 256, (int)(fill_color.B * intsv) % 256);
                    }
                    bmp.SetPixel(i, j, c);
                }

            pictureBox1.Refresh();
        }

        private void show_texture()
        {
            if (bmp != null)
                bmp.Dispose();
            rgbValues = getRGBValues(out bmp, out bmpData, out ptr, out bytes);
            figure.ApplyTexture(bmp, bmpData, rgbValues, texture, bmpDataTexture, rgbValuesTexture);
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);
            bmp.UnlockBits(bmpData);
            pictureBox1.Image = bmp;
        }

        private byte[] getRGBValues(out Bitmap bmp, out BitmapData bmpData,
            out IntPtr ptr, out int bytes)
        {
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, PixelFormat.Format24bppRgb);

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            bmpData =
                bmp.LockBits(rect, ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgb_values = new byte[bytes];

            // Create rgb array with background color
            for (int i = 0; i < bytes - 3; i += 3)
            {
                rgb_values[i] = pictureBox1.BackColor.R;
                rgb_values[i + 1] = pictureBox1.BackColor.G;
                rgb_values[i + 2] = pictureBox1.BackColor.B;
            }

            return rgb_values;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Point3D> points = new List<Point3D>();
            
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Graph != null)
            {
                if (e.KeyCode == Keys.A)
                    Graph.psi -= 10;
                else if (e.KeyCode == Keys.D)
                    Graph.psi += 10;
                else if (e.KeyCode == Keys.W)
                    Graph.phi -= 10;
                else if (e.KeyCode == Keys.S)
                    Graph.phi += 10;
                Graph.DrawGraphic();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) { }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Graph != null)
            {
                Graph.psi += 2;
                Graph.DrawGraphic();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            camRender();
        }

        private void camPosX_ValueChanged(object sender, EventArgs e)
        {
            camRender();
        }

        private void camPosY_ValueChanged(object sender, EventArgs e)
        {
            camRender();
        }

        private void camPosZ_ValueChanged(object sender, EventArgs e)
        {
            camRender();
        }

        private void camDirX_ValueChanged(object sender, EventArgs e)
        {
            camRender();
        }

        private void camDirY_ValueChanged(object sender, EventArgs e)
        {
            camRender();
        }

        private void camDirZ_ValueChanged(object sender, EventArgs e)
        {
            camRender();
        }
    }
}