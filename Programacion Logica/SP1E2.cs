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
    public partial class SP1E2 : Form
    {
        float fahrenheit, celsius, kelvin, rankine;
        public SP1E2()
        {
            InitializeComponent();
        }

        private void cmdConvertir_Click(object sender, EventArgs e)
        {
            fahrenheit = float.Parse(txtFahrenheit.Text);
            celsius = (fahrenheit - 32) * 5 / 9;
            kelvin = celsius + 273;
            rankine = fahrenheit + 460;
            lblCelsius.Text = "Celsius: " + (celsius.ToString("N2"));
            lblKelvin.Text = "Kelvin: " + kelvin.ToString("N2");
            lblRankine.Text = "Rankine: "+ rankine.ToString("N2");
        }
    }
}
