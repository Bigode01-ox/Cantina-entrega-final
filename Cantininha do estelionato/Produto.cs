﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantininha_do_estelionato
{
    public class Produto
    {
       public string nome { get; set; }
        public int codigo { get; set; }
        public decimal valor { get; set; }
        public int quantidade { get; set; }
        public bool iscozinha {  get; set; }





        public Produto(int codigo, string nome, decimal valor, int quantidade, bool iscozinha)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
            this.iscozinha = iscozinha;
        }
        

        public override string ToString()
        {
            return $"{nome} - R${valor} - {quantidade}";
        }
    }
}
