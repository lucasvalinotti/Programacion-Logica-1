using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Logica
{
    public partial class SP2E1 : Form
    {
        float largo, ancho, metro, area, importebruto, descuento, total;
        public SP2E1()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            largo = float.Parse(txtLargo.Text);
            ancho = float.Parse(txtAncho.Text);
            metro = float.Parse(txtPrecioMetro.Text);
            area = largo * ancho;
            importebruto= area * metro;
            if (area >= 400 && area < 500)
            {
                descuento = importebruto * 0.1f;
            }
            else if (area >= 500 && area < 1000)
            {
                descuento = importebruto * 0.17f;
            }
            else if (area >= 1000)
            {
                descuento = importebruto * 0.25f;
            }
            else
            {
                descuento = 0;
            }
            total = importebruto - descuento;
            lblImporteBruto.Text = importebruto.ToString("N2");
            lblDescuento.Text = descuento.ToString("N2");
            lblImporteFinal.Text = total.ToString("N2");
        }
    }
}
