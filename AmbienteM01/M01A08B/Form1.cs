namespace M01A08B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lblMsg.Text = "Muito prazer em te conhecer, " + nome + "!";
            lblMsg.Visible = true; // serve para deixar visível o label de mensagem
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
