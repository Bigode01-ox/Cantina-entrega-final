﻿using System;
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
            foreach (Pedido pidido in listaDePedidos.pedidos)
            {
                if (pidido.status == Status.Para_viagem || pidido.status == Status.Criado || pidido.status == Status.preparado)
                {
                    listBox1.Items.Add(pidido);
                }

                
                                 
                else if (pidido.status == Status.Concluido)
                {
                    listBox2.Items.Add(pidido);
                }





            }
        }

        private void Balcão_Load(object sender, EventArgs e)
        {

        }

        private void btnentregar_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                MessageBox.Show("Este pedido ja foi entregue");
            }


            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um pedido para entregar");
            }


            foreach (Pedido pidido in listaDePedidos.pedidos)
            {
                if (pidido.status == Status.Preparando)
                {
                    MessageBox.Show("O pedido precisa ser preparado antes de entregar");
                    return;
                }


            }


            foreach (var item in listBox1.SelectedItems)
            {
                if (item is Pedido itempedido)
                {
                    itempedido.status = Status.Concluido;
                    listBox2.Items.Add(itempedido);
                    MessageBox.Show("Pedido entregue");



                }


            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncozinha_Click(object sender, EventArgs e)
        {
            Cozinha cozinha = new Cozinha();    

            cozinha.ShowDialog();
        }
        
    }
}