namespace WinFormsAppManish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello {txtname.Text}");
        }
    }
}