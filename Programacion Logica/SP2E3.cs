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
    public partial class SP2E3 : Form
    {
        int dias;
        float precio, subtotal, descuento, total;
        public SP2E3()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            dias = int.Parse(txtDias.Text);
            precio = float.Parse(txtPrecio.Text);
            subtotal = precio * dias;
            if (dias >= 5 && dias < 10)
            {
                descuento = subtotal * 0.1f;
            }
            else if (dias >= 10 && dias < 15)
            {
                descuento = subtotal * 0.15f;
            }
            else if (dias >= 15)
            {
                descuento = subtotal * 0.2f;
            }
            else
            {
                descuento = 0;
            }
            total = subtotal - descuento;
            lblSubtotal.Text = subtotal.ToString("N2");
            lblDescuento.Text = descuento.ToString("N2");
            lblTotal.Text = total.ToString("N2");
        }
    }
}
