﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantininha_do_estelionato
{
    internal class Pedido
    {
        public string nome { get; set; }
        public string data { get; set; }
        
    }
        public enum status
    {
        Conluido,
        Preparando,
        feito,
        Para_viagem,
        
    }
}
