using System;
using SQLite.Net.Attributes;

namespace FomeLine.Models
{
    public class ItemDoPedido
    {
        public ItemDoPedido() { }

        [PrimaryKey, AutoIncrement]
        public int ItemDoPedidoId { get; set; }
        public int Quantidade { get; private set; }

        public decimal PrecoUnitario { get; private set; }

        public int ProdutoId { get; private set; }

        public int PedidoId { get; private set; }

        public void SetInformation(int qtde, decimal preco, int produtoId, int pedidoId)
        {
            Quantidade = qtde;
            PrecoUnitario = preco;
            ProdutoId = produtoId;
            PedidoId = pedidoId;
        }

        public bool IsValid()
        {
            if (Quantidade <= 0) throw new Exception("Quantidade Obrigatório");
            if (PrecoUnitario <= 0) throw new Exception("Preço Unitrário Obrigatório");
            if (ProdutoId <= 0) throw new Exception("Produto Obrigatório");
            if (PedidoId <= 0) throw new Exception("Pedido Obrigatório");
            return true;
        }
    }
}