using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Menu
{
    public partial class ListaPedidosMenuView : MasterDetailPage
    {
        public ListaPedidosMenuView()
        {
            InitializeComponent();
            BindingContext = new PedidoVm();
        }
    }
}