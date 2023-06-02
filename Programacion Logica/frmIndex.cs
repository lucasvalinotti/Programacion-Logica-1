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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void cmdSP1E1_Click(object sender, EventArgs e)
        {
            SP1E1 sP1E1= new SP1E1();
            sP1E1.ShowDialog();
        }

        private void cmdSP1E2_Click(object sender, EventArgs e)
        {
            SP1E2 sP1E2 = new SP1E2();
            sP1E2.ShowDialog();
        }

        private void cmdSP1E3_Click(object sender, EventArgs e)
        {
            SP1E3 sP1E3 = new SP1E3();
            sP1E3.ShowDialog();
        }

        private void cmdSP2E1_Click(object sender, EventArgs e)
        {
            SP2E1 sP2E1 = new SP2E1();
            sP2E1.ShowDialog();
        }

        private void cmdSP2E2_Click(object sender, EventArgs e)
        {
            SP2E2 sP2E2 = new SP2E2();
            sP2E2.ShowDialog();
        }

        private void cmdSP2E3_Click(object sender, EventArgs e)
        {
            SP2E3 sP2E3 = new SP2E3();
            sP2E3.ShowDialog();
        }

        private void cmdSP2E4_Click(object sender, EventArgs e)
        {
            SP2E4 sP2E4 = new SP2E4();
            sP2E4.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            SP3E1 sP3E1 = new SP3E1();
            sP3E1.ShowDialog();
        }

        private void cmdSP4E1_Click(object sender, EventArgs e)
        {
            SP4E1 sP4E1 = new SP4E1();
            sP4E1.ShowDialog();
        }

        private void cmdE10305_Click(object sender, EventArgs e)
        {
            frmE10305 form = new frmE10305();
            form.ShowDialog();
        }

        private void cmdE183105_Click(object sender, EventArgs e)
        {
            frmE183105 form = new frmE183105();
            form.ShowDialog();
        }
    }
}
