namespace Programacion_Logica
{
    partial class frmE10305
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
            this.nmcCorte = new System.Windows.Forms.NumericUpDown();
            this.lblCorte = new System.Windows.Forms.Label();
            this.cmdMientras = new System.Windows.Forms.Button();
            this.cmdRepetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCorte)).BeginInit();
            this.SuspendLayout();
            // 
            // nmcCorte
            // 
            this.nmcCorte.Location = new System.Drawing.Point(127, 9);
            this.nmcCorte.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmcCorte.Name = "nmcCorte";
            this.nmcCorte.Size = new System.Drawing.Size(120, 20);
            this.nmcCorte.TabIndex = 0;
            // 
            // lblCorte
            // 
            this.lblCorte.AutoSize = true;
            this.lblCorte.Location = new System.Drawing.Point(60, 11);
            this.lblCorte.Name = "lblCorte";
            this.lblCorte.Size = new System.Drawing.Size(35, 13);
            this.lblCorte.TabIndex = 1;
            this.lblCorte.Text = "Corte:";
            // 
            // cmdMientras
            // 
            this.cmdMientras.Location = new System.Drawing.Point(113, 50);
            this.cmdMientras.Name = "cmdMientras";
            this.cmdMientras.Size = new System.Drawing.Size(75, 23);
            this.cmdMientras.TabIndex = 3;
            this.cmdMientras.Text = "MIENTRAS";
            this.cmdMientras.UseVisualStyleBackColor = true;
            this.cmdMientras.Click += new System.EventHandler(this.cmdMientras_Click);
            // 
            // cmdRepetir
            // 
            this.cmdRepetir.Location = new System.Drawing.Point(113, 79);
            this.cmdRepetir.Name = "cmdRepetir";
            this.cmdRepetir.Size = new System.Drawing.Size(75, 23);
            this.cmdRepetir.TabIndex = 4;
            this.cmdRepetir.Text = "REPETIR";
            this.cmdRepetir.UseVisualStyleBackColor = true;
            this.cmdRepetir.Click += new System.EventHandler(this.cmdRepetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suma:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(145, 225);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(43, 13);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "______";
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(90, 108);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(120, 95);
            this.lstNumeros.TabIndex = 7;
            // 
            // frmE10305
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 250);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRepetir);
            this.Controls.Add(this.cmdMientras);
            this.Controls.Add(this.lblCorte);
            this.Controls.Add(this.nmcCorte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmE10305";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Numeros";
            ((System.ComponentModel.ISupportInitialize)(this.nmcCorte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmcCorte;
        private System.Windows.Forms.Label lblCorte;
        private System.Windows.Forms.Button cmdMientras;
        private System.Windows.Forms.Button cmdRepetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.ListBox lstNumeros;
    }
}