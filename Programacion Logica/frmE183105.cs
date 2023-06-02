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
    public partial class frmE183105 : Form
    {
        List<String> meses = new List<String>();
        List<Int32> ventas = new List<Int32>();
        int importe, promedioGeneral = 0, promedioEspecifico = 0, total = 0;
        string mes;

        private void frmE183105_Load(object sender, EventArgs e)
        {
            cargarVectores();
            lstMeses.DataSource= meses;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            mes = lstMeses.Text;
            int i = buscarMes(mes);
            try
            {
                importe = int.Parse(txtImporte.Text);
                if (i != -1)
                {
                    ventas[i] += importe;
                    MessageBox.Show("Importe cargado con exito en el mes " + mes + ".");
                    txtImporte.Clear();
                }
                else
                {
                    MessageBox.Show("Mes erroneo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public frmE183105()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            calcularPromedios();
            lbReporte.Items.Clear();
            for (int i = 11; i > -1; i--)
            {
                lbReporte.Items.Add(meses[i] + " $" + ventas[i].ToString());
            }
            lbReporte.Items.Add("Total: $" + total.ToString());
            lbReporte.Items.Add("Promedio General: $" + promedioGeneral.ToString());
            lbReporte.Items.Add("Promedio Especifico: $" + promedioEspecifico.ToString());
        }

        private void cmdReinciar_Click(object sender, EventArgs e)
        {
            reiniciarVentas();
            lbReporte.Items.Clear();
            txtImporte.Clear();
            promedioGeneral = 0;promedioEspecifico = 0;total = 0;
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void cargarVectores()
        {
            for (int i = 0; i < 12; i++)
            {
                ventas.Add(0);
                if (i == 0) meses.Add("Enero");
                if (i == 1) meses.Add("Febrero");
                if (i == 2) meses.Add("Marzo");
                if (i == 3) meses.Add("Abril");
                if (i == 4) meses.Add("Mayo");
                if (i == 5) meses.Add("Junio");
                if (i == 6) meses.Add("Julio");
                if (i == 7) meses.Add("Agosto");
                if (i == 8) meses.Add("Septiembre");
                if (i == 9) meses.Add("Octubre");
                if (i == 10) meses.Add("Noviembre");
                if (i == 11) meses.Add("Diciembre");
            }
        }

        private int buscarMes(string mes)
        {
            for (int i = 0; i < 12; i++)
            {
                if (meses[i] == mes)
                {
                    return i;
                }
            }
            return -1;
        }

        private void calcularPromedios()
        {
            int contador = 0;
            for (int i = 0; i < 12; i++)
            {
                total += ventas[i];
                if (ventas[i] != 0)
                {
                    contador++;
                }
            }
            promedioGeneral = total / 12;
            if (contador != 0) promedioEspecifico = total / contador;
            else promedioEspecifico = promedioGeneral;
        }

        private void reiniciarVentas() 
        {
            for (int i = 0; i < 12; i++)
            {
                ventas[i] = 0;
            }
        }
    }
}
