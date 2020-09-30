using System.Collections.Generic;

namespace QuickBuy.dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string  Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }


        /// <summary>
        /// Pedido deve ter pelo menos um pedido 
        /// ou muitos pedidos 
        /// </summary>
        public ICollection<ItemPedido> ItemPedidos   { get; set; }

    }
}
