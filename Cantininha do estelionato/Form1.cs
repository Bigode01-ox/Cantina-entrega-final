namespace Cantininha_do_estelionato
{
    public partial class Form1 : Form
    {
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Produto("Pão de Queijo", 3.50m, 0));
            listBox1.Items.Add(new Produto("Coxinha", 5.00m, 0));
            listBox1.Items.Add(new Produto("Pastel de Carne", 6.00m, 0));
            listBox1.Items.Add(new Produto("Pastel de Queijo", 5.50m, 0));
            listBox1.Items.Add(new Produto("Suco Natural (300ml)", 4.00m, 0));
            listBox1.Items.Add(new Produto("Refrigerante Lata", 4.50m, 0));
            listBox1.Items.Add(new Produto("Burgão Simples", 8.00m, 0));
            listBox1.Items.Add(new Produto("Burgão com Queijo", 9.00m, 0));
            listBox1.Items.Add(new Produto("X-Tudão", 12.00m, 0));
            listBox1.Items.Add(new Produto("Agua Mineral", 2.50m, 0));
        }

        private void PreçoTotal_click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                Produto itemSelecionado = (Produto)listBox1.SelectedItem;
                itemSelecionado.quantidade = (int)txtQuantidade.Value;
                listBox2.Items.Add(itemSelecionado);
                total += itemSelecionado.valor * itemSelecionado.quantidade;
                listBox1.ClearSelected();
                numero.Text = total.ToString();
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
                Produto itemSelecionado = (Produto)listBox2.SelectedItem;
                listBox2.Items.Remove(itemSelecionado);
                total -= itemSelecionado.valor; // total = total - itemSelecionado.valor;
                listBox1.ClearSelected();
                listBox2.ClearSelected();
                numero.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Selecione um item da comanda para remover");
            }



        }

        private void btnFecharpedido_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("A comanda ta vazia animal");
                return;
            }


            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                MessageBox.Show("Tem que por seu nome garai");
                return;
            }


            if (pagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha a Forma de Pagamento");
                return;
            }

            List<Produto> listadeprodutos = new List<Produto>();

            foreach (var item in listBox2.Items)
            {
                listadeprodutos.Add(item as Produto);
            }

            Pedido pidido = new Pedido()
            {
                nome = nome.Text,
                data = DateTime.Now,
                pagamento = pagamento.SelectedItem.ToString(),
                produtos = listadeprodutos,
                status = status.feito



            };
            listadepedidos.pedidos.Add(pidido);


            //MessageBox.Show(nome.Text);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numero_Click(object sender, EventArgs e)
        {

        }

        private void txtdinheiro_TextChanged(object sender, EventArgs e)
        {
            decimal valorRecebido = 0;
            decimal.TryParse(txtdinheiro.Text, out valorRecebido);
            decimal troco = valorRecebido - total;
            txttroco.Text = $"Troco: R$ {troco.ToString()}";



        }

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnviagem_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("A comanda ta vazia animal");
                return;
            }


            if (string.IsNullOrWhiteSpace(nome.Text))
            {
                MessageBox.Show("Tem que por seu nome garai");
                return;
            }


            if (pagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha a Forma de Pagamento");
                return;
            }



            MessageBox.Show($"PEDIDO EM PREPARAÇÃO \n\n{"Nome:"} {nome.Text}\n \n{"Forma de Pagamento:"} {pagamento.Text}  \n{DateTime.Now}\n{"Valor Total:"} {total:F2} \n pra viagem ");
            //MessageBox.Show(nome.Text);

        }

        private void pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balcão balcao = new Balcão();

            balcao.ShowDialog();
        }
    }
}
