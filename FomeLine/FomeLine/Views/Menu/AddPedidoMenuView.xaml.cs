using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Menu
{
    public partial class AddPedidoMenuView : MasterDetailPage
    {
        public AddPedidoMenuView()
        {
            InitializeComponent();
            BindingContext = new PedidoVm();
        }
    }
}