namespace PaneldeAbeja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBoxInputs = new GroupBox();
			textBoxSideHexagon = new TextBox();
			labelSideHexagon = new Label();
			groupBoxProcess = new GroupBox();
			buttonExit = new Button();
			buttonReset = new Button();
			buttonPlotBeePanel = new Button();
			groupBoxCanvas = new GroupBox();
			pictureBoxCanvas = new PictureBox();
			groupBoxInputs.SuspendLayout();
			groupBoxProcess.SuspendLayout();
			groupBoxCanvas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
			SuspendLayout();
			// 
			// groupBoxInputs
			// 
			groupBoxInputs.Controls.Add(textBoxSideHexagon);
			groupBoxInputs.Controls.Add(labelSideHexagon);
			groupBoxInputs.Location = new Point(14, 16);
			groupBoxInputs.Margin = new Padding(3, 4, 3, 4);
			groupBoxInputs.Name = "groupBoxInputs";
			groupBoxInputs.Padding = new Padding(3, 4, 3, 4);
			groupBoxInputs.Size = new Size(288, 135);
			groupBoxInputs.TabIndex = 0;
			groupBoxInputs.TabStop = false;
			groupBoxInputs.Text = "Entradas";
			// 
			// textBoxSideHexagon
			// 
			textBoxSideHexagon.Location = new Point(69, 84);
			textBoxSideHexagon.Margin = new Padding(3, 4, 3, 4);
			textBoxSideHexagon.Name = "textBoxSideHexagon";
			textBoxSideHexagon.Size = new Size(137, 27);
			textBoxSideHexagon.TabIndex = 1;
			textBoxSideHexagon.TextAlign = HorizontalAlignment.Center;
			// 
			// labelSideHexagon
			// 
			labelSideHexagon.AutoSize = true;
			labelSideHexagon.Location = new Point(69, 41);
			labelSideHexagon.Name = "labelSideHexagon";
			labelSideHexagon.Size = new Size(137, 20);
			labelSideHexagon.TabIndex = 0;
			labelSideHexagon.Text = "Lado del hexagono";
			// 
			// groupBoxProcess
			// 
			groupBoxProcess.Controls.Add(buttonExit);
			groupBoxProcess.Controls.Add(buttonReset);
			groupBoxProcess.Controls.Add(buttonPlotBeePanel);
			groupBoxProcess.Location = new Point(14, 170);
			groupBoxProcess.Margin = new Padding(3, 4, 3, 4);
			groupBoxProcess.Name = "groupBoxProcess";
			groupBoxProcess.Padding = new Padding(3, 4, 3, 4);
			groupBoxProcess.Size = new Size(288, 79);
			groupBoxProcess.TabIndex = 1;
			groupBoxProcess.TabStop = false;
			groupBoxProcess.Text = "Proceso";
			// 
			// buttonExit
			// 
			buttonExit.Location = new Point(192, 29);
			buttonExit.Margin = new Padding(3, 4, 3, 4);
			buttonExit.Name = "buttonExit";
			buttonExit.Size = new Size(86, 31);
			buttonExit.TabIndex = 2;
			buttonExit.Text = "Salir";
			buttonExit.UseVisualStyleBackColor = true;
			buttonExit.Click += buttonExit_Click;
			// 
			// buttonReset
			// 
			buttonReset.Location = new Point(99, 29);
			buttonReset.Margin = new Padding(3, 4, 3, 4);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(86, 31);
			buttonReset.TabIndex = 1;
			buttonReset.Text = "Resetear";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.Click += buttonReset_Click;
			// 
			// buttonPlotBeePanel
			// 
			buttonPlotBeePanel.Location = new Point(7, 29);
			buttonPlotBeePanel.Margin = new Padding(3, 4, 3, 4);
			buttonPlotBeePanel.Name = "buttonPlotBeePanel";
			buttonPlotBeePanel.Size = new Size(86, 31);
			buttonPlotBeePanel.TabIndex = 0;
			buttonPlotBeePanel.Text = "Graficar";
			buttonPlotBeePanel.UseVisualStyleBackColor = true;
			buttonPlotBeePanel.Click += buttonPlotBeePanel_Click;
			// 
			// groupBoxCanvas
			// 
			groupBoxCanvas.Controls.Add(pictureBoxCanvas);
			groupBoxCanvas.Location = new Point(309, 16);
			groupBoxCanvas.Margin = new Padding(3, 4, 3, 4);
			groupBoxCanvas.Name = "groupBoxCanvas";
			groupBoxCanvas.Padding = new Padding(3, 4, 3, 4);
			groupBoxCanvas.Size = new Size(592, 565);
			groupBoxCanvas.TabIndex = 2;
			groupBoxCanvas.TabStop = false;
			groupBoxCanvas.Text = "Salidas/Grafico";
			// 
			// pictureBoxCanvas
			// 
			pictureBoxCanvas.Location = new Point(7, 29);
			pictureBoxCanvas.Margin = new Padding(3, 4, 3, 4);
			pictureBoxCanvas.Name = "pictureBoxCanvas";
			pictureBoxCanvas.Size = new Size(578, 528);
			pictureBoxCanvas.TabIndex = 0;
			pictureBoxCanvas.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(909, 589);
			Controls.Add(groupBoxCanvas);
			Controls.Add(groupBoxProcess);
			Controls.Add(groupBoxInputs);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			groupBoxInputs.ResumeLayout(false);
			groupBoxInputs.PerformLayout();
			groupBoxProcess.ResumeLayout(false);
			groupBoxCanvas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBoxInputs;
        private GroupBox groupBoxProcess;
        private GroupBox groupBoxCanvas;
        private Label labelSideHexagon;
        private TextBox textBoxSideHexagon;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttonPlotBeePanel;
        private PictureBox pictureBoxCanvas;
    }
}
