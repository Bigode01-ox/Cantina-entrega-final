using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantininha_do_estelionato
{
    public partial class Balcão : Form
    {
        public Balcão()
        {
            InitializeComponent();
            foreach (Pedido pidido in listadepedidos.pedidos)
            {
                listBox1.Items.Add(pidido);

            }
        }

        private void Balcão_Load(object sender, EventArgs e)
        {

        }

        private void btnentregar_Click(object sender, EventArgs e)          
        { 
           
            if (listBox1.SelectedItem != null)
           {
               foreach (Pedido pidido in listadepedidos.pedidos)
               {
                    pidido.status = status.Conluido;
                    listBox2.Items.Add(pidido);
                    listBox1.ClearSelected();

                }
            }
            else
            {

                MessageBox.Show("Selecione um pedido para alterar ou entregar");
               
            }
           
            
        }
    }
}