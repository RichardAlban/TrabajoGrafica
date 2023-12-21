namespace WinAppHexagon
{
    partial class frmFigure
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.grbCanvas = new System.Windows.Forms.GroupBox();
			this.picCanvas = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblSide = new System.Windows.Forms.Label();
			this.btnDraw = new System.Windows.Forms.Button();
			this.txtSide = new System.Windows.Forms.TextBox();
			this.grbInput = new System.Windows.Forms.GroupBox();
			this.grbProcess = new System.Windows.Forms.GroupBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.grbCanvas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
			this.grbInput.SuspendLayout();
			this.grbProcess.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbCanvas
			// 
			this.grbCanvas.BackColor = System.Drawing.Color.White;
			this.grbCanvas.Controls.Add(this.picCanvas);
			this.grbCanvas.Location = new System.Drawing.Point(13, 13);
			this.grbCanvas.Margin = new System.Windows.Forms.Padding(4);
			this.grbCanvas.Name = "grbCanvas";
			this.grbCanvas.Padding = new System.Windows.Forms.Padding(4);
			this.grbCanvas.Size = new System.Drawing.Size(596, 519);
			this.grbCanvas.TabIndex = 19;
			this.grbCanvas.TabStop = false;
			// 
			// picCanvas
			// 
			this.picCanvas.BackColor = System.Drawing.Color.Gainsboro;
			this.picCanvas.Location = new System.Drawing.Point(19, 14);
			this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
			this.picCanvas.Name = "picCanvas";
			this.picCanvas.Size = new System.Drawing.Size(558, 497);
			this.picCanvas.TabIndex = 0;
			this.picCanvas.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.Location = new System.Drawing.Point(20, 132);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(186, 28);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblSide
			// 
			this.lblSide.AutoSize = true;
			this.lblSide.Location = new System.Drawing.Point(37, 32);
			this.lblSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSide.Name = "lblSide";
			this.lblSide.Size = new System.Drawing.Size(169, 16);
			this.lblSide.TabIndex = 0;
			this.lblSide.Text = "Ingrese el tamaño del lado:";
			this.lblSide.Click += new System.EventHandler(this.lblSide_Click);
			// 
			// btnDraw
			// 
			this.btnDraw.BackColor = System.Drawing.Color.White;
			this.btnDraw.Location = new System.Drawing.Point(20, 23);
			this.btnDraw.Margin = new System.Windows.Forms.Padding(4);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(186, 28);
			this.btnDraw.TabIndex = 0;
			this.btnDraw.Text = "Dibujar";
			this.btnDraw.UseVisualStyleBackColor = false;
			this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
			// 
			// txtSide
			// 
			this.txtSide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtSide.Location = new System.Drawing.Point(57, 67);
			this.txtSide.Margin = new System.Windows.Forms.Padding(4);
			this.txtSide.Name = "txtSide";
			this.txtSide.Size = new System.Drawing.Size(115, 22);
			this.txtSide.TabIndex = 1;
			this.txtSide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSide.TextChanged += new System.EventHandler(this.txtSide_TextChanged);
			// 
			// grbInput
			// 
			this.grbInput.BackColor = System.Drawing.Color.Transparent;
			this.grbInput.Controls.Add(this.txtSide);
			this.grbInput.Controls.Add(this.lblSide);
			this.grbInput.ForeColor = System.Drawing.Color.Black;
			this.grbInput.Location = new System.Drawing.Point(643, 28);
			this.grbInput.Margin = new System.Windows.Forms.Padding(4);
			this.grbInput.Name = "grbInput";
			this.grbInput.Padding = new System.Windows.Forms.Padding(4);
			this.grbInput.Size = new System.Drawing.Size(242, 132);
			this.grbInput.TabIndex = 16;
			this.grbInput.TabStop = false;
			this.grbInput.Text = "Entradas";
			this.grbInput.Enter += new System.EventHandler(this.grbInput_Enter);
			// 
			// grbProcess
			// 
			this.grbProcess.Controls.Add(this.btnExit);
			this.grbProcess.Controls.Add(this.btnReset);
			this.grbProcess.Controls.Add(this.btnDraw);
			this.grbProcess.Location = new System.Drawing.Point(643, 168);
			this.grbProcess.Margin = new System.Windows.Forms.Padding(4);
			this.grbProcess.Name = "grbProcess";
			this.grbProcess.Padding = new System.Windows.Forms.Padding(4);
			this.grbProcess.Size = new System.Drawing.Size(242, 180);
			this.grbProcess.TabIndex = 17;
			this.grbProcess.TabStop = false;
			this.grbProcess.Text = "Calculos";
			this.grbProcess.Enter += new System.EventHandler(this.grbProcess_Enter);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(20, 79);
			this.btnReset.Margin = new System.Windows.Forms.Padding(4);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(186, 28);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Resetear";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// frmFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(898, 534);
			this.Controls.Add(this.grbCanvas);
			this.Controls.Add(this.grbProcess);
			this.Controls.Add(this.grbInput);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmFigure";
			this.Text = "Praqnique 1.2 Pentágonos y Polígonos Estrellados de 5 Puntas";
			this.Load += new System.EventHandler(this.frmHexagon_Load);
			this.grbCanvas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
			this.grbInput.ResumeLayout(false);
			this.grbInput.PerformLayout();
			this.grbProcess.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnReset;
    }
}

