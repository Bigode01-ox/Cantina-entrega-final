
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantininha_do_estelionato
{
    public partial class Cozinha : Form
    {
        public Cozinha()
        {
            InitializeComponent();
            foreach (Pedido pidido in listadepedidos.pedidos)
            {
                if (pidido.status == status.Preparando)
                {
                    listBox1.Items.Add(pidido);
                }
               else if (pidido.status == status.Concluido)
                {
                    listBox2.Items.Add(pidido);
                }





            }
        }

       

        private void btnpreparar_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                MessageBox.Show("Este pedido ja foi preparado");
            }


            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um pedido para preparar");
            }


            foreach (var item in listBox1.SelectedItems)
            {
                if (item is Pedido itempedido)
                {
                    itempedido.status = status.Concluido;
                    listBox2.Items.Add(itempedido);
                    MessageBox.Show("Pedido preparado");



                }


            }
            listBox1.Items.Remove(listBox1.SelectedItem);

        }
    }
}
