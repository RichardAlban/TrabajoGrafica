namespace BeePanel;
public partial class Form1 : Form {
    private BeePanel? BeePanel { get; set; }

    public Form1() {
        InitializeComponent();
    }

    private void buttonPlotBeePanel_Click(object sender, EventArgs e) {
        pictureBoxCanvas.Refresh();

        try {
            float hexagonSide = float.Parse(textBoxSideHexagon.Text);
            BeePanel = new BeePanel(hexagonSide);

            BeePanel.Plot(pictureBoxCanvas, Color.Black, Color.Yellow);
        } catch (Exception) {
            MessageBox.Show("El valor ingresado no es valido");
        }

    }

    private void buttonReset_Click(object sender, EventArgs e) {
        textBoxSideHexagon.Text = "";
        pictureBoxCanvas.Refresh();
    }

    private void buttonExit_Click(object sender, EventArgs e) {
        Close();
    }
}