namespace Programacion_Logica
{
    partial class SP3E1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAngulo3 = new System.Windows.Forms.TextBox();
            this.txtAngulo2 = new System.Windows.Forms.TextBox();
            this.txtAngulo1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optObtusangulo = new System.Windows.Forms.RadioButton();
            this.optAcutangulo = new System.Windows.Forms.RadioButton();
            this.optRectangulo = new System.Windows.Forms.RadioButton();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAngulo3);
            this.groupBox1.Controls.Add(this.txtAngulo2);
            this.groupBox1.Controls.Add(this.txtAngulo1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtAngulo3
            // 
            this.txtAngulo3.Location = new System.Drawing.Point(64, 91);
            this.txtAngulo3.Name = "txtAngulo3";
            this.txtAngulo3.Size = new System.Drawing.Size(100, 20);
            this.txtAngulo3.TabIndex = 4;
            // 
            // txtAngulo2
            // 
            this.txtAngulo2.Location = new System.Drawing.Point(64, 59);
            this.txtAngulo2.Name = "txtAngulo2";
            this.txtAngulo2.Size = new System.Drawing.Size(100, 20);
            this.txtAngulo2.TabIndex = 3;
            // 
            // txtAngulo1
            // 
            this.txtAngulo1.Location = new System.Drawing.Point(64, 25);
            this.txtAngulo1.Name = "txtAngulo1";
            this.txtAngulo1.Size = new System.Drawing.Size(100, 20);
            this.txtAngulo1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angulo 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angulo 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angulo 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optObtusangulo);
            this.groupBox2.Controls.Add(this.optAcutangulo);
            this.groupBox2.Controls.Add(this.optRectangulo);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Triangulos";
            // 
            // optObtusangulo
            // 
            this.optObtusangulo.AutoSize = true;
            this.optObtusangulo.Location = new System.Drawing.Point(37, 65);
            this.optObtusangulo.Name = "optObtusangulo";
            this.optObtusangulo.Size = new System.Drawing.Size(85, 17);
            this.optObtusangulo.TabIndex = 2;
            this.optObtusangulo.TabStop = true;
            this.optObtusangulo.Text = "Obtusangulo";
            this.optObtusangulo.UseVisualStyleBackColor = true;
            // 
            // optAcutangulo
            // 
            this.optAcutangulo.AutoSize = true;
            this.optAcutangulo.Location = new System.Drawing.Point(37, 42);
            this.optAcutangulo.Name = "optAcutangulo";
            this.optAcutangulo.Size = new System.Drawing.Size(79, 17);
            this.optAcutangulo.TabIndex = 1;
            this.optAcutangulo.TabStop = true;
            this.optAcutangulo.Text = "Acutangulo";
            this.optAcutangulo.UseVisualStyleBackColor = true;
            // 
            // optRectangulo
            // 
            this.optRectangulo.AutoSize = true;
            this.optRectangulo.Location = new System.Drawing.Point(37, 19);
            this.optRectangulo.Name = "optRectangulo";
            this.optRectangulo.Size = new System.Drawing.Size(80, 17);
            this.optRectangulo.TabIndex = 0;
            this.optRectangulo.TabStop = true;
            this.optRectangulo.Text = "Rectángulo";
            this.optRectangulo.UseVisualStyleBackColor = true;
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(12, 246);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(172, 23);
            this.cmdVerificar.TabIndex = 6;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmdVerificar_Click);
            // 
            // SP3E1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 282);
            this.Controls.Add(this.cmdVerificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SP3E1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP3E1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAngulo3;
        private System.Windows.Forms.TextBox txtAngulo2;
        private System.Windows.Forms.TextBox txtAngulo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optObtusangulo;
        private System.Windows.Forms.RadioButton optAcutangulo;
        private System.Windows.Forms.RadioButton optRectangulo;
        private System.Windows.Forms.Button cmdVerificar;
    }
}