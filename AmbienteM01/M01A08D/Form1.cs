namespace M01A08D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNum.Text);
            int d = n * 2;
            lblMsg.Text = "O dobro do número " + n + " é " + d;
            lblMsg.Visible = true;
        }
    }
}
