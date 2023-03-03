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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Excelent");
            }
            else if(checkBox1.Checked)
            {
                MessageBox.Show("Good");
            }
            else if(checkBox2.Checked)
            {
                MessageBox.Show("Very Good");
            }
            else
            {
                MessageBox.Show("Please select one");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                MessageBox.Show("Playing");
            }
        }
    }
}
