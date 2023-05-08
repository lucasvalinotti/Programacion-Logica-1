using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Logica
{
    public partial class SP3E1 : Form
    {
        float angulouno, angulodos, angulotres, angulosinteriores;
        public SP3E1()
        {
            InitializeComponent();
        }

        private void cmdVerificar_Click(object sender, EventArgs e)
        {
            angulouno = float.Parse(txtAngulo1.Text);
            angulodos = float.Parse(txtAngulo2.Text);
            angulotres = float.Parse(txtAngulo3.Text);
            angulosinteriores = angulouno + angulodos + angulotres;
            if ((angulouno != 0 && angulodos != 0 && angulotres != 0) && angulosinteriores == 180)
            {
                if ((angulouno == 90 || angulodos == 90 || angulotres == 90) && optRectangulo.Checked == true)
                {
                    MessageBox.Show("Correcto! Si un ángulo mide 90° es un triángulo rectángulo", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((angulouno > 90 || angulodos > 90 || angulotres > 90) && optObtusangulo.Checked == true)
                {
                    MessageBox.Show("Correcto! Si un ángulo es obtuso (>90°) es un triángulo obtusángulo", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((angulouno < 90 && angulodos < 90 && angulotres < 90) && optAcutangulo.Checked == true)
                {
                    MessageBox.Show("Correcto! Si todos los ángulos son agudos(<90°) es un triángulo acutángulo", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrecto, volvé a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Medidas Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
