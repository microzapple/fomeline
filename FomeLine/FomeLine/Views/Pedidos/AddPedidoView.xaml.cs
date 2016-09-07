using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Pedidos
{
    public partial class AddPedidoView : ContentPage
    {
        public AddPedidoView()
        {
            InitializeComponent();
            BindingContext = new PedidoVm();
        }
    }
}