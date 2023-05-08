namespace Programacion_Logica
{
    partial class SP4E1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optMultiplosDiez = new System.Windows.Forms.RadioButton();
            this.optPares = new System.Windows.Forms.RadioButton();
            this.optMultiplosCinco = new System.Windows.Forms.RadioButton();
            this.optTodos = new System.Windows.Forms.RadioButton();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Final:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(86, 22);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optMultiplosDiez);
            this.groupBox1.Controls.Add(this.optPares);
            this.groupBox1.Controls.Add(this.optMultiplosCinco);
            this.groupBox1.Controls.Add(this.optTodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones a sumar";
            // 
            // optMultiplosDiez
            // 
            this.optMultiplosDiez.AutoSize = true;
            this.optMultiplosDiez.Location = new System.Drawing.Point(40, 133);
            this.optMultiplosDiez.Name = "optMultiplosDiez";
            this.optMultiplosDiez.Size = new System.Drawing.Size(120, 17);
            this.optMultiplosDiez.TabIndex = 3;
            this.optMultiplosDiez.Text = "Solo Multiplos de 10";
            this.optMultiplosDiez.UseVisualStyleBackColor = true;
            // 
            // optPares
            // 
            this.optPares.AutoSize = true;
            this.optPares.Location = new System.Drawing.Point(40, 66);
            this.optPares.Name = "optPares";
            this.optPares.Size = new System.Drawing.Size(118, 17);
            this.optPares.TabIndex = 2;
            this.optPares.Text = "Solo numeros pares";
            this.optPares.UseVisualStyleBackColor = true;
            // 
            // optMultiplosCinco
            // 
            this.optMultiplosCinco.AutoSize = true;
            this.optMultiplosCinco.Location = new System.Drawing.Point(40, 99);
            this.optMultiplosCinco.Name = "optMultiplosCinco";
            this.optMultiplosCinco.Size = new System.Drawing.Size(113, 17);
            this.optMultiplosCinco.TabIndex = 1;
            this.optMultiplosCinco.Text = "Solo multiplos de 5";
            this.optMultiplosCinco.UseVisualStyleBackColor = true;
            // 
            // optTodos
            // 
            this.optTodos.AutoSize = true;
            this.optTodos.Checked = true;
            this.optTodos.Location = new System.Drawing.Point(40, 33);
            this.optTodos.Name = "optTodos";
            this.optTodos.Size = new System.Drawing.Size(114, 17);
            this.optTodos.TabIndex = 0;
            this.optTodos.TabStop = true;
            this.optTodos.Text = "Todos los numeros";
            this.optTodos.UseVisualStyleBackColor = true;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(68, 240);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcular.TabIndex = 4;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suma:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(77, 286);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(109, 13);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "_________________";
            // 
            // SP4E1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 312);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label1);
            this.Name = "SP4E1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SP4E1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optMultiplosDiez;
        private System.Windows.Forms.RadioButton optPares;
        private System.Windows.Forms.RadioButton optMultiplosCinco;
        private System.Windows.Forms.RadioButton optTodos;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSuma;
    }
}