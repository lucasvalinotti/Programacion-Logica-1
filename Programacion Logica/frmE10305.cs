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
    public partial class frmE10305 : Form
    {
        decimal corte;
        int suma = 0, i = 1;
        public frmE10305()
        {
            InitializeComponent();
        }

        private void cmdRepetir_Click(object sender, EventArgs e)
        {
            corte = nmcCorte.Value;
            if (corte < 0 && (corte % 1 != 0))
            {
                MessageBox.Show("Cargar numero entero positivo.");
            }
            else
            {
                lstNumeros.Items.Clear();
                do
                {
                    lstNumeros.Items.Add("• " + i.ToString());
                    suma += i;
                    i++;
                } while (i<=corte);
                lblSuma.Text = suma.ToString();
                i = 1; suma = 0;
            }
        }

        private void cmdMientras_Click(object sender, EventArgs e)
        {
            corte = nmcCorte.Value;
            if (corte < 0 && (corte % 1 != 0))
            {
                MessageBox.Show("Cargar numero entero positivo.");
            }
            else
            {
                lstNumeros.Items.Clear();
                while (i <= corte) 
                {
                    lstNumeros.Items.Add("• " + i.ToString());
                    suma += i;
                    i++;
                }
                lblSuma.Text = suma.ToString();
                i = 1; suma = 0;
            }
        }
    }
}
