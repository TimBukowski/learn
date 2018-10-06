using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace graphicsLaba2
{
    public partial class Form1 : Form
    {
        Bitmap myBitmap;
        static Graphics gfx;
        
        PointF[] draw2D;    //переменная в которую мы выгружаем данные с объекта
        PointF[] tops_draw; //переменная в которую мы выгружаем данные с объекта

        Letter myLetter = new Letter();
        Pen myPen = new Pen(Color.DarkBlue);
        Pen r = new Pen(Color.Red, 1);
        Pen g = new Pen(Color.Green, 1);
        Pen b = new Pen(Color.Blue, 1);
        float q = 0;
        bool flag_run = true;

        public Form1()
        {
            InitializeComponent();
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(myBitmap);
            timer_run.Interval = 10;
            gfx.CompositingMode = CompositingMode.SourceOver;
            gfx.CompositingQuality = CompositingQuality.HighQuality;
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.SmoothingMode = SmoothingMode.HighQuality;
            gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
            gfx.TranslateTransform(300f, 300f);
            //gfx.RotateTransform(180f);
            Draw();
        }
        void Draw()
        {
            gfx.Clear(Color.White);
            draw2D = myLetter.Get2D();
            tops_draw = myLetter.GetTops();

            gfx.DrawLine(r, 0f, 0f, 0f, -500f);
            gfx.DrawLine(g, 0f, 0f, 500f, 0f);
            gfx.DrawLine(b, 0f, 0f, -500f, 500f);
            for (int i=0; i<myLetter.kol_tops; i++)
            {
                gfx.DrawLine(myPen, draw2D[Convert.ToInt32(tops_draw[i].X)] , draw2D[Convert.ToInt32(tops_draw[i].Y)]);
            }
            pictureBox1.Image = myBitmap;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void rotation_X_ValueChanged(object sender, EventArgs e)
        {
            myLetter.rotateX((float)rotation_X.Value);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        
        private void rotation_Y_ValueChanged(object sender, EventArgs e)
        {
            myLetter.rotateY((float)rotation_Y.Value);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void rotation_Z_ValueChanged(object sender, EventArgs e)
        {
            myLetter.rotateZ((float)rotation_Z.Value);

            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void trackBarZ0_ValueChanged(object sender, EventArgs e)
        {
            myLetter.Z0 = (float)trackBarZ0.Value;
            myLetter.to2D();

            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }
        private void shift_X_ValueChanged(object sender, EventArgs e)
        {
            float a = (float)shift_X.Value;
            myLetter.shift(a, 0, 0);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
            Draw();
        }
        private void shift_Y_ValueChanged(object sender, EventArgs e)
        {
            float a = (float)shift_Y.Value;
            myLetter.shift(0, a, 0);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void shift_Z_ValueChanged(object sender, EventArgs e)
        {
            float a = (float)shift_Z.Value;
            myLetter.shift(0, 0, a);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void reflectX_CheckedChanged(object sender, EventArgs e)
        {
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                myLetter.reflect_X();
            Draw();
        }

        private void reflectY_CheckedChanged(object sender, EventArgs e)
        {
            myLetter.reflect_Y();
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void reflectZ_CheckedChanged(object sender, EventArgs e)
        {
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                myLetter.reflect_Z();
            Draw();
        }

        private void scale_X_ValueChanged(object sender, EventArgs e)
        {
            float a = (float)scale_X.Value;
            myLetter.scale(a, 0, 0);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void scale_Y_ValueChanged(object sender, EventArgs e)
        {
            float a = (float)scale_Y.Value;
            myLetter.scale(0, a, 0);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void scale_Z_ValueChanged(object sender, EventArgs e)
        {
            float a = (float)scale_Z.Value;
            myLetter.scale(0, 0, a);
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }

        private void run_CheckedChanged(object sender, EventArgs e)
        {
            if (run.Checked == true)
            {
                timer_run.Enabled = true;
                timer_run.Start();
            }
            else
            { 
                timer_run.Enabled = false;
                timer_run.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myLetter.run();
            if (myLetter.check_border(pictureBox1.Height, pictureBox1.Width))
                Draw();
        }
    }
}
