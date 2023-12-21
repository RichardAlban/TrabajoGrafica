using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppHexagon
{
    public partial class frmFigure : Form
    {
        // Definición de un objeto de tipo CHexagon.
        CFigure ObjHexagon = new CFigure();

        public frmFigure()
        {
            InitializeComponent();
        }

        private void frmHexagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjHexagon.InitializeData(txtSide, picCanvas);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // Lectura de datos.
            // Llamada a la función ReadData.
            ObjHexagon.ReadData(txtSide);
            ObjHexagon.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjHexagon.InitializeData(txtSide, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierre de un formulario.
            // Llamada a la función CloseForm.
            ObjHexagon.CloseForm(this);
        }

        private void grbProcess_Enter(object sender, EventArgs e)
        {

        }

        private void txtSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbInput_Enter(object sender, EventArgs e)
        {

        }

		private void lblSide_Click(object sender, EventArgs e)
		{

		}
	}
}
