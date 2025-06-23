namespace Cantininha_do_estelionato
{
    public partial class Form1 : Form
    {
        List<Produto> listadeprodutos = new List<Produto>();
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
            txtQuantidade.Minimum = 1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Produto(1,"Pão de Queijo", 3.50m, 0, false));
            listBox1.Items.Add(new Produto(2,"Coxinha", 5.00m, 0, false));
            listBox1.Items.Add(new Produto(3,"Pastel de Carne", 6.00m, 0, true));
            listBox1.Items.Add(new Produto(4,"Pastel de Queijo", 5.50m, 0, true));
            listBox1.Items.Add(new Produto(4,"Suco Natural (300ml)", 4.00m, 0, false));
            listBox1.Items.Add(new Produto(5,"Refrigerante Lata", 4.50m, 0, false));
            listBox1.Items.Add(new Produto(6,"Burgão Simples", 8.00m, 0, true));
            listBox1.Items.Add(new Produto(7,"Burgão com Queijo", 9.00m, 0, true));
            listBox1.Items.Add(new Produto(8,"X-Tudão", 12.00m, 0, true));
            listBox1.Items.Add(new Produto(9,"Agua Mineral", 2.50m, 0, false));
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
               listBox2.Items.Remove(itemSelecionado.quantidade);
               listBox2.Items.Remove(itemSelecionado);
                total -= itemSelecionado.valor * itemSelecionado.quantidade;
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



            foreach (var item in listBox2.Items)
            {
                listadeprodutos.Add(item as Produto);
            }

            Pedido pidido = new Pedido();

            foreach (Produto produto in listBox2.Items)
            {
                if (produto.iscozinha == true)
                {
                    pidido.status = Status.Preparando;
                    break;
                }
                else
                {
                    pidido.status = btnparaviagem.Checked ? (Status)Enum.Parse(typeof(Status), "Para_viagem") : (Status)Enum.Parse(typeof(Status), "Criado");
                }
            }                  
                    
            pidido.nome = nome.Text;
            pidido.data = DateTime.Now;
            pidido.pagamento = pagamento.SelectedItem.ToString();
            pidido.produtos = listadeprodutos;

            listaDePedidos.pedidos.Add(pidido);
                

            MessageBox.Show($"PEDIDO EM PREPARAÇÃO \n Nome: {nome.Text}\n Forma de Pagamento: {pagamento.Text}  \n{DateTime.Now}\nValor Total: {total:F2} \n");
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

        private void pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balcão balcao = new Balcão();

            balcao.ShowDialog();
        }

        private void btnparaviagem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
