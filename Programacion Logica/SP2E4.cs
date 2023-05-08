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
    public partial class SP2E4 : Form
    {
        float altura, Base , resultadousuario;
        string resultado; 
        public SP2E4()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Base = float.Parse(txtBase.Text);
            altura = float.Parse(txtAltura.Text);
            resultadousuario = float.Parse(txtResultado.Text);
            resultado = ((Base * altura) / 2).ToString("N2");
            if (float.Parse(resultado) == resultadousuario)
            {
                MessageBox.Show("Felicidades! Resultado correcto.");
            }
            else
            {
                MessageBox.Show("Incorrecto :(. El resultado es " + resultado);
            }
        }
    }
}
