using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Menu
{
    public partial class ListaProdutosMenuView : MasterDetailPage
    {
        public ListaProdutosMenuView()
        {
            InitializeComponent();
            BindingContext = new ProdutoVm();
        }
    }
}