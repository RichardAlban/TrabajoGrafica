using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class frmCPE : Form
    {
        // Definición de un objeto de tipo CHexagon.
        CFiguraCPE ObjHexagon = new CFiguraCPE();

        public frmCPE()
        {
            InitializeComponent();
        }

        private void DibujarCambios()
        {
            txtRadius.Focus();
            //picCanvas.Refresh();
            // Lectura de datos.
            // Llamada a la función ReadData.
            ObjHexagon.ReadData(txtRadius);
            // Graficar un hexágono relleno con seis colores diferentes.
            // Llamada a la función PlotShape.
            ObjHexagon.PlotShape(picCanvas);
        }

        private void frmHexagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjHexagon.InitializeData(txtRadius, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DibujarCambios();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjHexagon.InitializeData(txtRadius, picCanvas);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario.
            // Llamada a la función CloseForm.
            ObjHexagon.CloseForm(this);

        }

        private void frmFigura_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grbProcess_Enter(object sender, EventArgs e)
        {

        }
    }
}
