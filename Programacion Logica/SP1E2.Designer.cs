namespace Programacion_Logica
{
    partial class SP1E2
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
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblRankine = new System.Windows.Forms.Label();
            this.cmdConvertir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(75, 6);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(124, 20);
            this.txtFahrenheit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fahrenheit";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(51, 16);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(82, 13);
            this.lblCelsius.TabIndex = 2;
            this.lblCelsius.Text = "Celsius: ______";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(50, 44);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(84, 13);
            this.lblKelvin.TabIndex = 3;
            this.lblKelvin.Text = "Kelvin: _______";
            // 
            // lblRankine
            // 
            this.lblRankine.AutoSize = true;
            this.lblRankine.Location = new System.Drawing.Point(51, 74);
            this.lblRankine.Name = "lblRankine";
            this.lblRankine.Size = new System.Drawing.Size(89, 13);
            this.lblRankine.TabIndex = 4;
            this.lblRankine.Text = "Rankine: ______";
            // 
            // cmdConvertir
            // 
            this.cmdConvertir.Location = new System.Drawing.Point(46, 138);
            this.cmdConvertir.Name = "cmdConvertir";
            this.cmdConvertir.Size = new System.Drawing.Size(127, 51);
            this.cmdConvertir.TabIndex = 5;
            this.cmdConvertir.Text = "CONVERTIR";
            this.cmdConvertir.UseVisualStyleBackColor = true;
            this.cmdConvertir.Click += new System.EventHandler(this.cmdConvertir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCelsius);
            this.groupBox1.Controls.Add(this.lblKelvin);
            this.groupBox1.Controls.Add(this.lblRankine);
            this.groupBox1.Location = new System.Drawing.Point(5, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // SP1E2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 199);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdConvertir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFahrenheit);
            this.Name = "SP1E2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP1E2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblRankine;
        private System.Windows.Forms.Button cmdConvertir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

