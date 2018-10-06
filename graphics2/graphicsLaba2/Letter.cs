using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace graphicsLaba2
{
    class Letter
    {
        private Coordinates3D[] m_crd3D;    //координаты 3Д
        private PointF[] m_crd2D;       //координаты преобразованные из 3Д в 2Д
        private PointF[] tops_crd;    //координаты вершин
        private int k_tops;
        private int k_crd;
        private string fileName = "vertex.txt";
        private string tops = "tops.txt";
        private float z0 = 1000f;
        private float rotationX = 0f;
        private float rotationY = 0f;
        private float rotationZ = 0f;
        private float shiftX = 0f;
        private float shiftY = 0f;
        private float shiftZ = 0f;
        private float scaleX = 1f;
        private float scaleY = 1f;
        private float scaleZ = 1f;
        private float how_run_x = 1f;
        private float how_run_y = 0f;
        private float angle = 0f;
        private bool flag_x = true;
        private bool flag_y = true;

        public Letter()
        {
            this.k_crd = crdGetFromFile();   //подсчет кол-во элементов в массиве
            crdFill();     //заполнение массива координатами
            this.k_tops = topsGetFromFile();
            topsCrd();      //заполнение массива вершин связями
            to2D();
        }

        public void crdFill()
        {
            using (StreamReader sr = new StreamReader(this.fileName))
            {
                m_crd3D = new Coordinates3D[this.k_crd];
                string line;
                string[] lineElem;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    lineElem = line.Split(' ');
                    this.m_crd3D[i] = new Coordinates3D();
                    this.m_crd3D[i].X = Convert.ToSingle(lineElem[0]) * 15;
                    this.m_crd3D[i].Y = Convert.ToSingle(lineElem[1]) * 15 * (-1);
                    this.m_crd3D[i].Z = Convert.ToSingle(lineElem[2]) *10;
                    //проверили координаты, всё ок
                    //MessageBox.Show(m_crd3D[i].X.ToString() + m_crd3D[i].Y.ToString() + m_crd3D[i].Z.ToString(), "Coordinates");
                    i++;
                }
            }
        }
        public int crdGetFromFile()
        {
            if (!File.Exists(this.fileName))
                File.Create(this.fileName);
            int i = 0; //глобальная в функции для подсчета кол-во элементов
            using (StreamReader sr = new StreamReader(this.fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                }
            }
            return i;
        }
        public int topsGetFromFile()
        {
            if (!File.Exists(this.tops))
                File.Create(this.tops);
            int i = 0; //глобальная в функции для подсчета кол-во связей вершин
            using (StreamReader sr = new StreamReader(this.tops))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                }
            }
            return i;
        }
        public void topsCrd()
        {
            this.k_tops = topsGetFromFile(); //получили кол-во связей в вершинах
            this.tops_crd = new PointF[this.k_tops];
            this.m_crd2D = new PointF[this.k_tops];
            if (!File.Exists(this.tops))
                File.Create(this.tops);
            using (StreamReader sr = new StreamReader(this.tops))
            {
                string line;
                string[] lineElem;
                int i = 0;
                while ((line = sr.ReadLine()) != null)          //получаем матрицу связей вершин
                {
                    this.tops_crd[i] = new PointF();
                    lineElem = line.Split(' ');
                    this.tops_crd[i].X = Convert.ToSingle(lineElem[0]);
                    this.tops_crd[i].Y = Convert.ToSingle(lineElem[1]);
                    //MessageBox.Show(tops_crd[i][0].ToString() + tops_crd[i][1].ToString(), "Tops");
                    i++;
                }
            }
        }
        public void to2D()
        {
            for (int i = 0; i < this.k_crd; i++)
            {
                this.m_crd2D[i] = new PointF();
                this.m_crd2D[i].X = (float)this.m_crd3D[i].X / ((float)1 - (float)this.m_crd3D[i].Z / this.z0);
                this.m_crd2D[i].Y = (float)this.m_crd3D[i].Y / ((float)1 - (float)this.m_crd3D[i].Z / this.z0);
            }
        }
        public void rotateX(float g)
        {
            PointF temp = new PointF();
            float gr = (float)((g - this.rotationX) * Math.PI / 180f);
            for (int i = 0; i < this.k_crd; i++)
            {
                temp.X = this.m_crd3D[i].Y * (float)(Math.Cos(gr)) - this.m_crd3D[i].Z * (float)Math.Sin(gr);
                temp.Y = this.m_crd3D[i].Y * (float)(Math.Sin(gr)) + this.m_crd3D[i].Z * (float)Math.Cos(gr);
                this.m_crd3D[i].Y = temp.X;
                this.m_crd3D[i].Z = temp.Y;
            }
            this.to2D();
            this.rotationX = g;
        }
        public void rotateY(float g)
        {
            PointF temp = new PointF();
          
                float gr = (float)((g - this.rotationY) * Math.PI / 180f);
            //this.rotationY = gr;
        
            for (int i = 0; i < this.k_crd; i++)
            {
                temp.X = this.m_crd3D[i].X * (float)(Math.Cos(gr)) + this.m_crd3D[i].Z * (float)Math.Sin(gr);
                temp.Y = -this.m_crd3D[i].X * (float)(Math.Sin(gr)) + this.m_crd3D[i].Z * (float)Math.Cos(gr);
                this.m_crd3D[i].X = temp.X;
                this.m_crd3D[i].Z = temp.Y;
            }
            this.rotationY = g;
            this.to2D();
        }
        public void rotateZ(float g)
        {
            PointF temp = new PointF();
            float gr = (float)((g - this.rotationZ) * Math.PI / 180f);
            for (int i = 0; i < this.k_crd; i++)
            {
                temp.X = this.m_crd3D[i].X * (float)(Math.Cos(gr)) - this.m_crd3D[i].Y * (float)Math.Sin(gr);
                temp.Y = this.m_crd3D[i].X * (float)(Math.Sin(gr)) + this.m_crd3D[i].Y * (float)Math.Cos(gr);
                this.m_crd3D[i].X = temp.X;
                this.m_crd3D[i].Y = temp.Y;
            }
            this.rotationZ = g;
            this.to2D();
        }
        public void shift(float a, float b, float c) //сдвиг
        {
            b = -b;
            c = -c;
            int flag = -1;
            for (int i = 0; i < this.k_crd; i++)
            {
                if(a != 0)
                {
                    if(a > shiftX)
                        this.m_crd3D[i].X = this.m_crd3D[i].X + (a-shiftX);
                    else
                        this.m_crd3D[i].X = this.m_crd3D[i].X + (a-shiftX);
                    flag = 1;
                }
                if (b != 0)
                {
                        if (b > shiftY)
                        this.m_crd3D[i].Y = this.m_crd3D[i].Y + (b-shiftY);
                    else
                        this.m_crd3D[i].Y = this.m_crd3D[i].Y + (b-shiftY);
                    flag = 2;
                }
                if (c != 0)
                {
                        if (c >shiftZ)
                        this.m_crd3D[i].Z = this.m_crd3D[i].Z + (c - shiftZ);
                    else
                        this.m_crd3D[i].Z = this.m_crd3D[i].Z + (c - shiftZ);
                    flag = 3;
                }
            }
            if(flag == 1)shiftX = a;
            if(flag == 2)shiftY = b;
            if(flag == 3)shiftZ = c;
            this.to2D();
        }
        public void scale(float a, float b, float c) //сдвиг
        {
            b = -b;
            c = -c;
            int flag = -1;
            a *= (float)0.05;
            b *= -(float)0.05;
            c *= (float)0.05;
            for (int i = 0; i < this.k_crd; i++)
            {
                if (a != 0)
                {
                    if (a > scaleX)
                        this.m_crd3D[i].X = this.m_crd3D[i].X * (a / scaleX);
                    else
                        this.m_crd3D[i].X = this.m_crd3D[i].X * (a / scaleX);
                    flag = 1;
                }
                if (b != 0)
                {
                    if (b > scaleY)
                        this.m_crd3D[i].Y = this.m_crd3D[i].Y * (b / scaleY);
                    else
                        this.m_crd3D[i].Y = this.m_crd3D[i].Y * (b / scaleY);
                    flag = 2;
                }
                if (c != 0)
                {
                    if (c > scaleZ)
                        this.m_crd3D[i].Z = this.m_crd3D[i].Z * (c / scaleZ);
                    else
                        this.m_crd3D[i].Z = this.m_crd3D[i].Z * (c / scaleZ);
                    flag = 3;
                }
            }
            if (flag == 1) scaleX = a;
            if (flag == 2) scaleY = b;
            if (flag == 3) scaleZ = c;
            this.to2D();
        }
        public float RotationX
        {
            get { return this.rotationX; }
            set {
                if (value > this.rotationX)
                    this.rotationX = value;
                else
                    this.rotationX = this.rotationX - (this.rotationX - value);
            }
        }
        public float RotationY
        {
            get { return this.rotationY; }
            set
            {
                if (value > this.rotationY)
                    this.rotationY = value;
                else
                    this.rotationY = this.rotationY - (this.rotationY - value);
            }
        }
        public float RotationZ
        {
            get { return this.rotationZ; }
            set
            {
                if (value > this.rotationZ)
                    this.rotationZ = value;
                else
                    this.rotationZ = this.rotationZ - (this.rotationZ - value);
            }
        }
        public void reflect_X()
        {
            for(int i=0; i<k_crd;i++)
            {
                this.m_crd3D[i].Y *= -1;
            }
            this.to2D();
        }
        public void reflect_Y()
        {
            for (int i = 0; i < k_crd; i++)
            {
                this.m_crd3D[i].X *= -1;
            }
            this.to2D();
        }
        public void reflect_Z()
        {
            for (int i = 0; i < k_crd; i++)
            {
                this.m_crd3D[i].Z *= -1;
            }
            this.to2D();
        }
        public bool check_border(int height, int width)
        {
            bool flag = true;
            for(int i = 0; i < k_crd; i++)
            {
                if ((m_crd3D[i].X <= -280 || m_crd3D[i].X >=width-320) || (m_crd3D[i].Y <= -280 || m_crd3D[i].Y >= height-300)) //выходит за границы
                    flag = false;
            }
            return flag;
        }
        public void run()
        {
            shift(this.how_run_x, 0, 0);
            shift(0, this.how_run_y, 0);
            if (flag_x == true)
            {
                this.how_run_x += 1f;
                //метод движение вперед
                if (this.how_run_x > 865f - 420f)
                    flag_x = false;
             }
             else 
                 if(flag_x == false)
                 {
                    this.how_run_x -= 1f;
                    //метод движение назад
                    if (this.how_run_x < -280f)
                            flag_x = true;
                 }
             if (flag_y == true)
             {
                 this.how_run_y = 150 * (float)(Math.Sin(angle*Math.PI/180f));
                 angle++;
                if (angle == 360f)
                {
                    flag_y = false;
                   //  angle = 0;
                }
            }
             else
                 if (flag_y == false)
             {
                this.how_run_y = -150 * (float)(Math.Sin(angle * Math.PI / 180f));
                angle--;

                if (angle == 0f)
                { 
                     flag_y = true;
                }
            }
            this.to2D();
        }

        public float Z0
        {
            get { return this.z0; }
            set {
                if (value > this.z0)
                    this.z0 = value;
                else
                    this.z0 = this.z0 - (this.z0 - value);
            }
        }
        public int kol_crd
        {
            get { return this.k_crd; }
        }
        public int kol_tops
        {
            get { return this.k_tops; }
        }
        public PointF[] Get2D()
        {
            return this.m_crd2D;
        }
        public PointF[] GetTops()
        {
            return this.tops_crd;
        }
    }
}
