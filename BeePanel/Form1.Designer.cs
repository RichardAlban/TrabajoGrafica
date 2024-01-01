namespace BeePanel
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
            groupBoxInputs.Location = new Point(12, 12);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(252, 67);
            groupBoxInputs.TabIndex = 0;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Entradas";
            // 
            // textBoxSideHexagon
            // 
            textBoxSideHexagon.Location = new Point(126, 28);
            textBoxSideHexagon.Name = "textBoxSideHexagon";
            textBoxSideHexagon.Size = new Size(117, 23);
            textBoxSideHexagon.TabIndex = 1;
            // 
            // labelSideHexagon
            // 
            labelSideHexagon.AutoSize = true;
            labelSideHexagon.Location = new Point(6, 31);
            labelSideHexagon.Name = "labelSideHexagon";
            labelSideHexagon.Size = new Size(114, 15);
            labelSideHexagon.TabIndex = 0;
            labelSideHexagon.Text = "Lado l del hexagono";
            // 
            // groupBoxProcess
            // 
            groupBoxProcess.Controls.Add(buttonExit);
            groupBoxProcess.Controls.Add(buttonReset);
            groupBoxProcess.Controls.Add(buttonPlotBeePanel);
            groupBoxProcess.Location = new Point(12, 85);
            groupBoxProcess.Name = "groupBoxProcess";
            groupBoxProcess.Size = new Size(252, 59);
            groupBoxProcess.TabIndex = 1;
            groupBoxProcess.TabStop = false;
            groupBoxProcess.Text = "Proceso";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(168, 22);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Salir";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(87, 22);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Resetear";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonPlotBeePanel
            // 
            buttonPlotBeePanel.Location = new Point(6, 22);
            buttonPlotBeePanel.Name = "buttonPlotBeePanel";
            buttonPlotBeePanel.Size = new Size(75, 23);
            buttonPlotBeePanel.TabIndex = 0;
            buttonPlotBeePanel.Text = "Graficar";
            buttonPlotBeePanel.UseVisualStyleBackColor = true;
            buttonPlotBeePanel.Click += buttonPlotBeePanel_Click;
            // 
            // groupBoxCanvas
            // 
            groupBoxCanvas.Controls.Add(pictureBoxCanvas);
            groupBoxCanvas.Location = new Point(270, 12);
            groupBoxCanvas.Name = "groupBoxCanvas";
            groupBoxCanvas.Size = new Size(518, 424);
            groupBoxCanvas.TabIndex = 2;
            groupBoxCanvas.TabStop = false;
            groupBoxCanvas.Text = "Salidas/Grafico";
            // 
            // pictureBoxCanvas
            // 
            pictureBoxCanvas.Location = new Point(6, 22);
            pictureBoxCanvas.Name = "pictureBoxCanvas";
            pictureBoxCanvas.Size = new Size(506, 396);
            pictureBoxCanvas.TabIndex = 0;
            pictureBoxCanvas.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 442);
            Controls.Add(groupBoxCanvas);
            Controls.Add(groupBoxProcess);
            Controls.Add(groupBoxInputs);
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
