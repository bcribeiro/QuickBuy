using QuickBuy.dominio.ObjetodeValor;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace QuickBuy.dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataProvisaoEntrega{get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoID { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    
        ///  <summary>
        /// pEDIDO DEVE TER PELO MENOS UM ITEM DE PEDIDO 
        /// Ou muitos itens de pedidos 
        /// </summary>

        public ICollection<ItemPedido> ItensPedidos { get; set }

    }
}
