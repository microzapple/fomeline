using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Pedidos
{
    public partial class ListaPedidoView : ContentPage
    {
        public ListaPedidoView()
        {
            InitializeComponent();
            BindingContext = new PedidoVm();
        }
    }
}