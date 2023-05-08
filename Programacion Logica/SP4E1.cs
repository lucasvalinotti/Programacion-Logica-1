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
    public partial class SP4E1 : Form
    {
        int hasta, opcion;
        public SP4E1()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            hasta = int.Parse(txtHasta.Text);
            if (optTodos.Checked == true) 
            { 
                opcion= 1;
            }
            else if (optPares.Checked == true)
            {
                opcion = 2;
            }
            else if (optMultiplosCinco.Checked == true)
            {
                opcion = 5;
            }
            else if (optMultiplosDiez.Checked == true)
            {
                opcion = 10;
            }
            Sumar(opcion);
        }

        private void Sumar(int inicio)
        {
            int numero = inicio;
            int suma = 0;
            while (numero <= hasta)
            {
                suma += numero;
                numero += inicio;
            }
            lblSuma.Text = suma.ToString();
        }
    }
}
