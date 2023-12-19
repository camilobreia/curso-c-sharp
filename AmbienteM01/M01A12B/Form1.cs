namespace M01A12B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMsg.Text = $"O ano atual é {DateTime.Now.Year}";
        }
    }
}
