namespace StarPolygon;
public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private void buttonPlotShape_Click(object sender, EventArgs e) {
        pictureBoxCanvas.Refresh();

        try {
            float pentagonSide = float.Parse(textBoxSidePentagon.Text);
            PointF origin = new(pictureBoxCanvas.Width / 2, pictureBoxCanvas.Height / 2);

            StarPolygon starPolygon = new(pentagonSide, origin);
            starPolygon.Plot(pictureBoxCanvas);
            
        } catch (Exception exc) {
            MessageBox.Show("El valor ingresado no es valido: " + exc);
        }

    }

    private void buttonReset_Click(object sender, EventArgs e) {
        textBoxSidePentagon.Text = "";
        pictureBoxCanvas.Refresh();
    }

    private void buttonExit_Click(object sender, EventArgs e) {
        Close();
    }
}