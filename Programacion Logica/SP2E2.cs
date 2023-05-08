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
    public partial class SP2E2 : Form
    {
        public SP2E2()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNumeroUno.Text) == int.Parse(txtNumeroDos.Text))
            {
                MessageBox.Show("Los datos ingresados son iguales");
            }
            else
            {
                if (int.Parse(txtNumeroUno.Text) > int.Parse(txtNumeroDos.Text))
                {
                    MessageBox.Show("El Primer Dato es Mayor");
                }
                else
                {
                    MessageBox.Show("El Primer Dato es Menor");
                }
            }
        }
    }
}
