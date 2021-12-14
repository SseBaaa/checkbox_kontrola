using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Posalji_Click(object sender, EventArgs e)
        {
            txtbox.Clear();
            txtbox.AppendText("Odabrali ste: "+ Environment.NewLine);
            if (dorucak.Checked) 
            {
                txtbox.AppendText(dorucak.Text + Environment.NewLine);
            }
            if (rucak.Checked)
            {
                txtbox.AppendText(rucak.Text + Environment.NewLine);
            }
            if (vecera.Checked)
            {
                txtbox.AppendText(vecera.Text + Environment.NewLine);
            }
        }

        private void sakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (sakrij.Checked)
                {
                    txtbox.Hide();
                }
             else
            {
                txtbox.Show();
            }
        }
    }
}
