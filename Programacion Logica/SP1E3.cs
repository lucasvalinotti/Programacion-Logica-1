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
    public partial class SP1E3 : Form
    {
        int reproducciones = 0;
        public SP1E3()
        {
            InitializeComponent();
        }

        private void cmdReproducir_Click(object sender, EventArgs e)
        {
            reproducciones++;
            lblReproducciones.Text = reproducciones.ToString();
        }
    }
}
