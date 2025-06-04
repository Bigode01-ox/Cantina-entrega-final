using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantininha_do_estelionato
{
    public class Produto
    {
       public string nome { get; set; }

        public decimal valor { get; set; }
        public int quantidade { get; set; }

        public Produto(string nome, decimal valor, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return $"{nome} - R${valor} - {quantidade}";
        }
    }
}
