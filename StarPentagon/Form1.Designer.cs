namespace StarPolygon
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
            textBoxSidePentagon = new TextBox();
            labelSidePentagon = new Label();
            groupBoxProcess = new GroupBox();
            buttonExit = new Button();
            buttonReset = new Button();
            buttonShape = new Button();
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
            groupBoxInputs.Controls.Add(textBoxSidePentagon);
            groupBoxInputs.Controls.Add(labelSidePentagon);
            groupBoxInputs.Location = new Point(12, 12);
            groupBoxInputs.Name = "groupBoxInputs";
            groupBoxInputs.Size = new Size(252, 67);
            groupBoxInputs.TabIndex = 0;
            groupBoxInputs.TabStop = false;
            groupBoxInputs.Text = "Entradas";
            // 
            // textBoxSidePentagon
            // 
            textBoxSidePentagon.Location = new Point(126, 28);
            textBoxSidePentagon.Name = "textBoxSidePentagon";
            textBoxSidePentagon.Size = new Size(117, 23);
            textBoxSidePentagon.TabIndex = 1;
            // 
            // labelSidePentagon
            // 
            labelSidePentagon.AutoSize = true;
            labelSidePentagon.Location = new Point(6, 31);
            labelSidePentagon.Name = "labelSidePentagon";
            labelSidePentagon.Size = new Size(114, 15);
            labelSidePentagon.TabIndex = 0;
            labelSidePentagon.Text = "Lado l del pentagono";
            // 
            // groupBoxProcess
            // 
            groupBoxProcess.Controls.Add(buttonExit);
            groupBoxProcess.Controls.Add(buttonReset);
            groupBoxProcess.Controls.Add(buttonShape);
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
            // buttonShape
            // 
            buttonShape.Location = new Point(6, 22);
            buttonShape.Name = "buttonShape";
            buttonShape.Size = new Size(75, 23);
            buttonShape.TabIndex = 0;
            buttonShape.Text = "Graficar";
            buttonShape.UseVisualStyleBackColor = true;
            buttonShape.Click += buttonPlotShape_Click;
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
        private Label labelSidePentagon;
        private TextBox textBoxSidePentagon;
        private Button buttonExit;
        private Button buttonReset;
        private Button buttonShape;
        private PictureBox pictureBoxCanvas;
    }
}
