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
    public partial class SP1E1 : Form
    {
        int X;
        public SP1E1()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            X = int.Parse(txtX.Text);
            double y = 3 * Math.Pow(X, 2) + 7 * X - 15;
            lblY.Text = y.ToString();
        }
    }
}
