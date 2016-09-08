namespace FomeLine.ViewModels
{
    public class ItemDoPedidoVm : BaseVm
    {
        private int _itemId;
        public int ItemDoPedidoId
        {
            get
            {
                return _itemId;
            }
            set
            {
                _itemId = value;
                Notify(nameof(ItemDoPedidoId));
            }
        }

        private int _quantidade;
        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                _quantidade = value;
                Notify(nameof(Quantidade));
            }
        }

        private decimal _precoUnitario;
        public decimal PrecoUnitario
        {
            get
            {
                return _precoUnitario;
            }
            set
            {
                _precoUnitario = value;
                Notify(nameof(PrecoUnitario));
            }
        }

        private int _produtoId;
        public int ProdutoId
        {
            get
            {
                return _produtoId;
            }
            set
            {
                _produtoId = value;
                Notify(nameof(ProdutoId));
            }
        }

        private int _pedidoId;
        public int PedidoId
        {
            get
            {
                return _pedidoId;
            }
            set
            {
                _pedidoId = value;
                Notify(nameof(PedidoId));
            }
        }


    }
}