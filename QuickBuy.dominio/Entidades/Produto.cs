using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.dominio.Entidades
{
    public class Produto
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

    }
}
