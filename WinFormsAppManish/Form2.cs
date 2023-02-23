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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblResult.Text = Convert.ToString(Convert.ToSingle(txtN1.Text) + Convert.ToSingle(txtN2.Text));

        }
    }
}
