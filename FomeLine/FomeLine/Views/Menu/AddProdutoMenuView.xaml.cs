using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Menu
{
    public partial class AddProdutoMenuView : MasterDetailPage
    {
        public AddProdutoMenuView()
        {
            InitializeComponent();
            BindingContext = new ProdutoVm();
        }
    }
}