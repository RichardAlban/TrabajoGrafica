using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppHexagon
{
    class CFigure
    {
        private float mSide;
        private const float SF = 18;
        private Graphics mGraph;
        private Pen mPen;


        public CFigure()
        {
        }

        // Función que lee el lado del hexágono.
        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text) * 2;

            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }



        // Función que inicializa los datos y controles del hexágono.
        public void InitializeData(TextBox txtSide,
                                   PictureBox picCanvas)
        {
            txtSide.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
            mSide = 0.0f;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            PointF[] pPentagon = new PointF[5];
            PointF[] pInvertPentagon = new PointF[5];
            PointF[] pSmallPentagon = new PointF[5];
            PointF[] pStar = new PointF[5];
            PointF[] pSmallStar = new PointF[5];
            PointF[] pPoint = new PointF[5];
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 3);
            pPentagon = DrawPentagon(picCanvas);
            pInvertPentagon = DrawInvertPentagon(picCanvas);
            pSmallPentagon = DrawSmallPentagon(picCanvas);
            DrawLine(picCanvas, pPentagon, pInvertPentagon, pSmallPentagon);
            pStar = DrawStar(picCanvas);
            pSmallStar = DrawSmallStar(picCanvas);
            DrawLineStar(picCanvas, pStar, pSmallPentagon);
            pPoint = Point(picCanvas);
            StarPolygon(picCanvas, pPoint, pSmallStar);
            pSmallStar = DrawSmallStar(picCanvas);
        }
        //Funcion de dibujo y de retorno de coordenadas del pentagono exterior
        public PointF[] DrawPentagon(PictureBox picCanvas)
        {
            var points = new PointF[5];
            float size;
            mPen = new Pen(Color.Red, 2);
            size = mSide / 2;
            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointF(size + (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), size + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
                PointF start = new PointF(size + (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), size + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
                PointF end = new PointF(size + (size * (float)Math.Sin((2 * Math.PI) / 5 * (i + 1) + (Math.PI / 2 - Math.PI / 5))), size + (size * (float)Math.Cos((2 * Math.PI) / 5 * (i + 1) + (Math.PI / 2 - Math.PI / 5))));
                mGraph.DrawLine(mPen, start.X * SF, start.Y * SF, end.X * SF, end.Y * SF);
            }
            return points;
        }
        //Funcion de dibujo y de retorno de coordenadas del pentagono exterior invertido
        public PointF[] DrawInvertPentagon(PictureBox picCanvas)
        {
            var points = new PointF[5];
            float size;
            mPen = new Pen(Color.Blue, 2);
            size = mSide / 2;
            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointF(size - (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), size + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
                PointF start = new PointF(size - (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), size + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
                PointF end = new PointF(size - (size * (float)Math.Sin((2 * Math.PI) / 5 * (i + 1) + (Math.PI / 2 - Math.PI / 5))), size + (size * (float)Math.Cos((2 * Math.PI) / 5 * (i + 1) + (Math.PI / 2 - Math.PI / 5))));
                mGraph.DrawLine(mPen, start.X * SF, start.Y * SF, end.X * SF, end.Y * SF);
            }
            return points;
        }

        //Funcion de dibujo y de retorno de coordenadas del pentagono  interno
        public PointF[] DrawSmallPentagon(PictureBox picCanvas)
        {
            var points = new PointF[5];
            float size;
            float point;
            mPen = new Pen(Color.Yellow, 2);
            size = (mSide + 1) / 3;
            point = mSide / 2;
            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointF(point + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), point + (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
                PointF start = new PointF(point + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), point + (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
                PointF end = new PointF(point + (size * (float)Math.Cos((2 * Math.PI) / 5 * (i + 1) + (Math.PI / 2 - Math.PI / 5))), point + (size * (float)Math.Sin((2 * Math.PI) / 5 * (i + 1) + (Math.PI / 2 - Math.PI / 5))));
                mGraph.DrawLine(mPen, start.X * SF, start.Y * SF, end.X * SF, end.Y * SF);
            }
            return points;
        }
        // Funcion para dibujar las lineas que estan dentro del pentagono central
        public void DrawLine(PictureBox picCanvas, PointF[] pPentagon, PointF[] pInvertPentagon, PointF[] pSmallPentagon)
        {
            mPen = new Pen(Color.Black, 1);
            mGraph.DrawLine(mPen, pPentagon[3].X * SF, pPentagon[3].Y * SF, pSmallPentagon[1].X * SF, pSmallPentagon[1].Y * SF);
            mGraph.DrawLine(mPen, pInvertPentagon[4].X * SF, pPentagon[4].Y * SF, pSmallPentagon[1].X * SF, pSmallPentagon[1].Y * SF);

            mGraph.DrawLine(mPen, pPentagon[4].X * SF, pPentagon[4].Y * SF, pSmallPentagon[0].X * SF, pSmallPentagon[0].Y * SF);
            mGraph.DrawLine(mPen, pInvertPentagon[3].X * SF, pPentagon[3].Y * SF, pSmallPentagon[0].X * SF, pSmallPentagon[0].Y * SF);

            mGraph.DrawLine(mPen, pPentagon[0].X * SF, pPentagon[0].Y * SF, pSmallPentagon[4].X * SF, pSmallPentagon[4].Y * SF);
            mGraph.DrawLine(mPen, pInvertPentagon[2].X * SF, pPentagon[2].Y * SF, pSmallPentagon[4].X * SF, pSmallPentagon[4].Y * SF);

            mGraph.DrawLine(mPen, pPentagon[1].X * SF, pPentagon[1].Y * SF, pSmallPentagon[3].X * SF, pSmallPentagon[3].Y * SF);
            mGraph.DrawLine(mPen, pInvertPentagon[1].X * SF, pPentagon[1].Y * SF, pSmallPentagon[3].X * SF, pSmallPentagon[3].Y * SF);

            mGraph.DrawLine(mPen, pPentagon[2].X * SF, pPentagon[2].Y * SF, pSmallPentagon[2].X * SF, pSmallPentagon[2].Y * SF);
            mGraph.DrawLine(mPen, pInvertPentagon[0].X * SF, pPentagon[0].Y * SF, pSmallPentagon[2].X * SF, pSmallPentagon[2].Y * SF);
        }
        //Dibujo de la estrella del  centro con retorno de coordenadas
        public PointF[] DrawStar(PictureBox picCanva)
        {
            var points = new PointF[5];
            float size;
            float point;
            mPen = new Pen(Color.GreenYellow, 2);
            size = (mSide + (211 / 100)) / (4);
            point = mSide / 2;
            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointF(point - (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), point - (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
            }
            int side = 5;
            for (int i = 0; i < side; i++)
            {
                if (i < side / 2 + 1)
                {
                    if (i - 1 < 0)
                    {
                        mGraph.DrawLine(mPen, points[side - 1].X * SF, points[side - 1].Y * SF, points[i + side / 2].X * SF, points[i + side / 2].Y * SF);
                    }
                    else
                    {
                        mGraph.DrawLine(mPen, points[i - 1].X * SF, points[i - 1].Y * SF, points[i + 5 / 2].X * SF, points[i + side / 2].Y * SF);
                    }
                    mGraph.DrawLine(mPen, points[i].X * SF, points[i].Y * SF, points[i + side / 2].X * SF, points[i + side / 2].Y * SF);
                }
            }
            return points;
        }
        // Funcion de dibujar la estrella que esta en el centro
        public PointF[] DrawSmallStar(PictureBox picCanva)
        {
            var points = new PointF[5];
            float size;
            float point;
            mPen = new Pen(Color.Orange, 1);
            size = (mSide - 1) / (9);
            point = mSide / 2;
            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointF(point + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), point + (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
            }
            int side = 5;
            for (int i = 0; i < side; i++)
            {
                if (i < side / 2 + 1)
                {
                    if (i - 1 < 0)
                    {
                        mGraph.DrawLine(mPen, points[side - 1].X * SF, points[side - 1].Y * SF, points[i + side / 2].X * SF, points[i + side / 2].Y * SF);
                    }
                    else
                    {
                        mGraph.DrawLine(mPen, points[i - 1].X * SF, points[i - 1].Y * SF, points[i + 5 / 2].X * SF, points[i + side / 2].Y * SF);
                    }
                    mGraph.DrawLine(mPen, points[i].X * SF, points[i].Y * SF, points[i + side / 2].X * SF, points[i + side / 2].Y * SF);
                }
            }
            return points;
        }
        //Funcion para dibujar las lineas 
        public void DrawLineStar(PictureBox picCanvas, PointF[] pStar, PointF[] pSmallPentagon)
        {
            var points = new PointF[6];
            mPen = new Pen(Color.Black, 1);

            mGraph.DrawLine(mPen, pSmallPentagon[4].X * SF, pSmallPentagon[4].Y * SF, pStar[3].X * SF, pStar[3].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[4].X * SF, pSmallPentagon[4].Y * SF, pStar[0].X * SF, pStar[0].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[1].X * SF, pSmallPentagon[1].Y * SF, pStar[0].X * SF, pStar[0].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[1].X * SF, pSmallPentagon[1].Y * SF, pStar[2].X * SF, pStar[2].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[3].X * SF, pSmallPentagon[3].Y * SF, pStar[2].X * SF, pStar[2].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[3].X * SF, pSmallPentagon[3].Y * SF, pStar[4].X * SF, pStar[4].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[0].X * SF, pSmallPentagon[0].Y * SF, pStar[4].X * SF, pStar[4].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[0].X * SF, pSmallPentagon[0].Y * SF, pStar[1].X * SF, pStar[1].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[2].X * SF, pSmallPentagon[2].Y * SF, pStar[1].X * SF, pStar[1].Y * SF);
            mGraph.DrawLine(mPen, pSmallPentagon[2].X * SF, pSmallPentagon[2].Y * SF, pStar[3].X * SF, pStar[3].Y * SF);

        }
        //Funcion para determinar el punto medio de dos cordenadas
        public PointF[] Point(PictureBox picCanvas)
        {
            var points = new PointF[5];
            float size;
            float point;
            mPen = new Pen(Color.Red, 2);
            size = (mSide + 3) / 6;
            point = mSide / 2;
            for (int i = 0; i < 5; i++)
            {
                points[i] = new PointF(point + (size * (float)Math.Cos((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))), point - (size * (float)Math.Sin((2 * Math.PI) / 5 * i + (Math.PI / 2 - Math.PI / 5))));
            }
            return points;
        }

        //Funcion para unir puntos y rellenarlo de color solido
        public void StarPolygon(PictureBox picCanvas, PointF[] pPoint, PointF[] pSmallStar)
        {

            PointF point1 = new PointF(pSmallStar[4].X * SF, pSmallStar[4].Y * SF);
            PointF point2 = new PointF(pPoint[4].X * SF, pPoint[4].Y * SF);
            PointF point3 = new PointF(pSmallStar[0].X * SF, pSmallStar[0].Y * SF);
            PointF point4 = new PointF(pPoint[3].X * SF, pPoint[3].Y * SF);
            PointF point5 = new PointF(pSmallStar[1].X * SF, pSmallStar[1].Y * SF);
            PointF point6 = new PointF(pPoint[2].X * SF, pPoint[2].Y * SF);
            PointF point7 = new PointF(pSmallStar[2].X * SF, pSmallStar[2].Y * SF);
            PointF point8 = new PointF(pPoint[1].X * SF, pPoint[1].Y * SF);
            PointF point9 = new PointF(pSmallStar[3].X * SF, pSmallStar[3].Y * SF);
            PointF point10 = new PointF(pPoint[0].X * SF, pPoint[0].Y * SF);
            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };
            mGraph.DrawPolygon(mPen, curvePoints);
        }

        // Función que cierra un formulario.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}

