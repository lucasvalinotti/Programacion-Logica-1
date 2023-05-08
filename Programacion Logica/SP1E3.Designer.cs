namespace Programacion_Logica
{
    partial class SP1E3
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
            this.cmdReproducir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReproducciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdReproducir
            // 
            this.cmdReproducir.Location = new System.Drawing.Point(168, 12);
            this.cmdReproducir.Name = "cmdReproducir";
            this.cmdReproducir.Size = new System.Drawing.Size(159, 56);
            this.cmdReproducir.TabIndex = 0;
            this.cmdReproducir.Text = "Reproducir";
            this.cmdReproducir.UseVisualStyleBackColor = true;
            this.cmdReproducir.Click += new System.EventHandler(this.cmdReproducir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reproducciones:";
            // 
            // lblReproducciones
            // 
            this.lblReproducciones.AutoSize = true;
            this.lblReproducciones.Location = new System.Drawing.Point(236, 87);
            this.lblReproducciones.Name = "lblReproducciones";
            this.lblReproducciones.Size = new System.Drawing.Size(91, 13);
            this.lblReproducciones.TabIndex = 2;
            this.lblReproducciones.Text = "______________";
            // 
            // SP1E3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 122);
            this.Controls.Add(this.lblReproducciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdReproducir);
            this.Name = "SP1E3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP1E3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdReproducir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReproducciones;
    }
}