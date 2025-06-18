
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

        private void Cozinha_Load(object sender, EventArgs e)
        {

        }
    }
}
