namespace Cantininha_do_estelionato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PreçoTotal_click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            if (!string.IsNullOrEmpty(nome))
            {
                listBox1.Items.Add(nome);
                txtNome.Clear();
                txtNome.Focus();
            }
        }
    }
}
