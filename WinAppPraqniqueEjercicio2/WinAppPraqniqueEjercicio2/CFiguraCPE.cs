using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    class CFiguraCPE
    {
        // Radio de los poligonos
        private float radius1, radius2, radius3, radius4;
        private float angle;
        private Graphics graph;
        private const float SF = 20;
        // Centro del poligono
        private PointF O;
        private PointF[] polPointsCentros = {};
        // 8 Poligonos medianos
        private PointF[][] polsPointsMed = {};
        // 8 Poligonos pequeños
        private PointF[][] cuadPointsPeq = {};
        private Pen mPen1;
		private Pen mPen2;
		private Pen mPen3;
		private Pen mPen4;

		// Funciones miembro - Métodos.
		// Constructor sin parámetros.

		public CFiguraCPE()
        {
            radius1 = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                radius1 = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }

 
        public void InitializeData(TextBox txtSide, PictureBox picCanvas)
        {
            txtSide.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }


        // Función que calcula los vertices de un poligono
        private PointF[] CalculateVertex(float rotationAngle, float radius, int numLados, PointF centro)
        {
            PointF[] vertexs = {};
            float currentAngle;

            angle = 2.0f * (float)Math.PI / numLados; //numero de lados 6 para hexagono
            
            Array.Resize(ref vertexs, numLados + 1);
            
            for (int i = 0; i < numLados; i++) {
                currentAngle = i * angle + rotationAngle;
                vertexs[i].X = centro.X + radius * (float)Math.Cos(currentAngle);
                vertexs[i].Y = centro.Y + radius * (float)Math.Sin(currentAngle);
            }

            vertexs[numLados].X = vertexs[0].X;
            vertexs[numLados].Y = vertexs[0].Y;

            return vertexs;

        }

        // Función que grafica la figura completa
        public void PlotShape(PictureBox picCanvas)
        {
            float fnumB;
            graph = picCanvas.CreateGraphics();

            mPen1 = new Pen(Color.Red, 2);
			mPen2 = new Pen(Color.Blue, 2);
			mPen3 = new Pen(Color.Green, 2);
			mPen4 = new Pen(Color.Black, 2);

			//Redimensionamos la figura para que estos se vean mejor atravez del radio inicial
			radius1 *= SF;

            // Cálculo de radios necesarios
            radius2 = (float) (radius1 * (1 - Math.Cos(Math.PI/4)));
            radius3 = radius1 - radius2;

            // poligono con vertices como centro de los demas poligonos pequeños
            O.X = picCanvas.Width/2; O.Y = picCanvas.Height/2; //Centro p1
            polPointsCentros = CalculateVertex(0, radius3, 8, O);

            // calculo de poligonos medianos
            Array.Resize(ref polsPointsMed, 8);

            for(int i = 0; i <  polPointsCentros.Length - 1; i++)
            {
                polsPointsMed[i] = CalculateVertex(0, radius2, 8, polPointsCentros[i]);
            }

            // Calculo de cuadrados pequeños
            fnumB = (float)(Math.Sqrt(Math.Pow(polsPointsMed[7][2].Y - O.Y, 2) + Math.Pow(polsPointsMed[7][2].X - O.X, 2)));
            radius4 = (float)(radius3 - (fnumB / (Math.Cos(Math.PI / 8))));            

            Array.Resize(ref cuadPointsPeq, 8);

            for (int i = 0; i < polPointsCentros.Length - 1; i++)
            {
                if(i % 2 == 0)
                {
                    cuadPointsPeq[i] = CalculateVertex(0, radius4, 4, polPointsCentros[i]);
                } else
                {
                    cuadPointsPeq[i] = CalculateVertex((float) Math.PI / 4, radius4, 4, polPointsCentros[i]);
                }
                
            }

            //Graficamos el circulo exterior
            graph.DrawEllipse(mPen1, O.X - radius1, O.Y - radius1, 2 * radius1, 2 * radius1);


            // Graficamos los poligonos medianos
            for (int i = 0; i < polsPointsMed.Length; i++)
            {
                for (int j = 0; j < polsPointsMed[i].Length - 1; j++)
                {
                    graph.DrawLine(mPen2, polsPointsMed[i][j].X, polsPointsMed[i][j].Y, polsPointsMed[i][j + 1].X, polsPointsMed[i][j + 1].Y);
                }
            }

            // Grafica de las estrellas

            for (int i = 0; i < cuadPointsPeq.Length; i++)
            {
                for (int j = 0; j < cuadPointsPeq[i].Length - 1; j++)
                {
                    // Union de puntos cuando estamos en un pooligono par
                    if(i % 2 == 0)
                    {
                        graph.DrawLine(mPen3, cuadPointsPeq[i][j].X, cuadPointsPeq[i][j].Y, polsPointsMed[i][2 * j + 1].X, polsPointsMed[i][2 * j + 1].Y);
                        if (j == 0) // este if se usa ya que el la conbinación 0 - 7 no se puede incluir en el for
                        {
                            graph.DrawLine(mPen3, cuadPointsPeq[i][0].X, cuadPointsPeq[i][0].Y, polsPointsMed[i][7].X, polsPointsMed[i][7].Y);
                        } else
                        {
                            graph.DrawLine(mPen3, cuadPointsPeq[i][j].X, cuadPointsPeq[i][j].Y, polsPointsMed[i][2 * j - 1].X, polsPointsMed[i][2 * j - 1].Y);
                        }
                        
                    }
                    else // Union de puntos cuando estamos en un pooligono inpar
                    {
                        graph.DrawLine(mPen1, cuadPointsPeq[i][j].X, cuadPointsPeq[i][j].Y, polsPointsMed[i][j * 2].X, polsPointsMed[i][j * 2].Y);
                        graph.DrawLine(mPen1, cuadPointsPeq[i][j].X, cuadPointsPeq[i][j].Y, polsPointsMed[i][2 * j + 2].X, polsPointsMed[i][2 * j + 2].Y);
                    }
                }
            }

            //Graficamos las lineas que van del centro a cada uno de los poligonos medianos
            for(int i = 0; i < 4;  i++)
            {
                graph.DrawLine(mPen4, O.X, O.Y, polsPointsMed[i][i + 4].X, polsPointsMed[i][i + 4].Y);                                    
            }

            for (int i = 4; i < polsPointsMed.Length; i++)
            {
                graph.DrawLine(mPen4, O.X, O.Y, polsPointsMed[i][i - 4].X, polsPointsMed[i][i - 4].Y);
            }
        }

        // Función que cierra un formulario.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
