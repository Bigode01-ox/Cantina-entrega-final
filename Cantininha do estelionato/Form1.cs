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
            listBox1.Items.Add("P�o de Queijo");

        }

        private void Pre�oTotal_click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                object itemSelecionado = listBox1.SelectedItem;
                listBox2.Items.Add(itemSelecionado);
                listBox1.ClearSelected();
            }
            else
            {
                MessageBox.Show("Selecione um item para adicionar");
            }


        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                object itemSelecionado = listBox2.SelectedItem;
                listBox2.Items.Remove(itemSelecionado);
                listBox1.ClearSelected();
            }
            else
            {
                MessageBox.Show("Selecione um item da comanda para remover");
            }


        }

        private void btnFecharpedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pedido em prepara��o \n{nome.Text} \n{DateTime.Now}");
            //MessageBox.Show(nome.Text);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
