using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Produtos
{
    public partial class AddProdutoView : ContentPage
    {
        public AddProdutoView()
        {
            InitializeComponent();
            BindingContext = new ProdutoVm();
        }
    }
}