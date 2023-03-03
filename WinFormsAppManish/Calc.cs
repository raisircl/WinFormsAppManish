using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppManish
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void btnDigit_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            textBox1.Text = btn.Text;

        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }
    }
}
