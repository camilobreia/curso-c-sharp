namespace M01A08F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n = 0;
            int.TryParse(txtNum.Text, out n);
            int d = n * 2;
            lblMsg.Text = "O dobro de " + n + " é " + d;
            lblMsg.Visible = true;
        }
    }
}
