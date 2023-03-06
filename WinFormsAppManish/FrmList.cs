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
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!lbCourses.Items.Contains(txtCourse.Text))
                lbCourses.Items.Add(txtCourse.Text);
            else
                MessageBox.Show("Item allready exist");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = lbCourses.Items.Count;
            lblCourses.Text = "";
            for (int i = 0; i < x; i++)
            {
                lblCourses.Text += lbCourses.Items[i].ToString() + "\n";
            }
        }

        private void lbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbCourses.SelectedIndex>-1)
            {
                lblCourses.Text = lbCourses.SelectedItem.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                lblCourses.Text = comboBox1.SelectedItem.ToString();
            }
        }
    }
}
