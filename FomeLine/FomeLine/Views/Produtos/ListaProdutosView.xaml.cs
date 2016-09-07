using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Produtos
{
    public partial class ListaProdutosView : ContentPage
    {
        public ListaProdutosView()
        {
            InitializeComponent();
            BindingContext = new ProdutoVm();
        }
    }
}