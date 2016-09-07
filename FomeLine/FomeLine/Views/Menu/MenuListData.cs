using System.Collections.Generic;
using FomeLine.Views.Pedidos;
using FomeLine.Views.Produtos;

namespace FomeLine.Views.Menu
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            Add(new MenuItem()
            {
                Titulo = "Início",
                TargetType = typeof(HomeView)
            });

            Add(new MenuItem()
            {
                Titulo = "Produtos",
                TargetType = typeof(ListaProdutosView)
            });

            Add(new MenuItem()
            {
                Titulo = "Pedidos",
                TargetType = typeof(ListaPedidoView)
            });
            
        }
    }
}