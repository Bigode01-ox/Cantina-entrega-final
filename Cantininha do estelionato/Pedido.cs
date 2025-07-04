﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantininha_do_estelionato
{
    public class Pedido
    {
        public string nome { get; set; }
        public DateTime data { get; set; }
        public string pagamento { get; set; }
        public List<Produto> produtos { get; set; }
        public Status status { get; set; } 

        public override string ToString()
        {
            return $"{nome} - {data} - {pagamento} - {status}";
         }
    } 
}
