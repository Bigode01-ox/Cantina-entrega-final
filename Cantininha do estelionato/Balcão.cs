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
      
    }
}
