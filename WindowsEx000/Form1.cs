namespace WindowsEx000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "Olá, Mundo!"; // text muda a propriedade text do label
        }
    }
}
