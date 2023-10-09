using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirim_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);

           if (rbİndirim1.Checked)
            {
                tutar = tutar * 0.95;
            }

           else if (rbİndirim2.Checked)
            {
                tutar = tutar * 0.90;
            }

           else if (rbİndirim3.Checked)
            {
                tutar = tutar * 0.85;
            }

           else if (rbİndirim4.Checked)
            {
                tutar = tutar * 0.75;
            }

            lblİndirim.Text = tutar.ToString();
        }
    }
}
