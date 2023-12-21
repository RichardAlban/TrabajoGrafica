namespace GDI
{
    partial class frmCPE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.grbInputs = new System.Windows.Forms.GroupBox();
			this.txtRadius = new System.Windows.Forms.TextBox();
			this.lblWidth = new System.Windows.Forms.Label();
			this.grbProcess = new System.Windows.Forms.GroupBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.grbCanvas = new System.Windows.Forms.GroupBox();
			this.picCanvas = new System.Windows.Forms.PictureBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.grbInputs.SuspendLayout();
			this.grbProcess.SuspendLayout();
			this.grbCanvas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// grbInputs
			// 
			this.grbInputs.Controls.Add(this.txtRadius);
			this.grbInputs.Controls.Add(this.lblWidth);
			this.grbInputs.Location = new System.Drawing.Point(798, 34);
			this.grbInputs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbInputs.Name = "grbInputs";
			this.grbInputs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbInputs.Size = new System.Drawing.Size(251, 145);
			this.grbInputs.TabIndex = 0;
			this.grbInputs.TabStop = false;
			this.grbInputs.Text = "Entradas";
			// 
			// txtRadius
			// 
			this.txtRadius.Location = new System.Drawing.Point(40, 76);
			this.txtRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRadius.Name = "txtRadius";
			this.txtRadius.Size = new System.Drawing.Size(140, 22);
			this.txtRadius.TabIndex = 0;
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(18, 42);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(61, 16);
			this.lblWidth.TabIndex = 0;
			this.lblWidth.Text = "Tamaño:";
			// 
			// grbProcess
			// 
			this.grbProcess.Controls.Add(this.btnExit);
			this.grbProcess.Controls.Add(this.btnReset);
			this.grbProcess.Controls.Add(this.btnCalculate);
			this.grbProcess.Location = new System.Drawing.Point(798, 214);
			this.grbProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbProcess.Name = "grbProcess";
			this.grbProcess.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbProcess.Size = new System.Drawing.Size(251, 200);
			this.grbProcess.TabIndex = 1;
			this.grbProcess.TabStop = false;
			this.grbProcess.Text = "Proceso";
			this.grbProcess.Enter += new System.EventHandler(this.grbProcess_Enter);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(55, 137);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(110, 38);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(55, 96);
			this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(110, 36);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Resetear";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(55, 58);
			this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(110, 34);
			this.btnCalculate.TabIndex = 0;
			this.btnCalculate.Text = "Calcular";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// grbCanvas
			// 
			this.grbCanvas.Controls.Add(this.picCanvas);
			this.grbCanvas.Location = new System.Drawing.Point(12, 34);
			this.grbCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbCanvas.Name = "grbCanvas";
			this.grbCanvas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grbCanvas.Size = new System.Drawing.Size(753, 528);
			this.grbCanvas.TabIndex = 1;
			this.grbCanvas.TabStop = false;
			this.grbCanvas.Text = "Gráfico";
			// 
			// picCanvas
			// 
			this.picCanvas.Location = new System.Drawing.Point(5, 21);
			this.picCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.picCanvas.Name = "picCanvas";
			this.picCanvas.Size = new System.Drawing.Size(742, 503);
			this.picCanvas.TabIndex = 0;
			this.picCanvas.TabStop = false;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// frmCPE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1061, 585);
			this.Controls.Add(this.grbProcess);
			this.Controls.Add(this.grbCanvas);
			this.Controls.Add(this.grbInputs);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmCPE";
			this.Text = "Gráfica de Figura";
			this.Load += new System.EventHandler(this.frmFigura_Load);
			this.grbInputs.ResumeLayout(false);
			this.grbInputs.PerformLayout();
			this.grbProcess.ResumeLayout(false);
			this.grbCanvas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}