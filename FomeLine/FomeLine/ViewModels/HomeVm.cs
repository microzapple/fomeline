using System.Windows.Input;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class HomeVm : BaseVm
    {
        public ICommand HomeCommand { get; set; }
        public ICommand ListaProdutosCommand { get; set; }
        public ICommand ListaPedidosCommand { get; set; }

        public HomeVm()
        {
            HomeCommand = new Command(GoToHome);
            ListaProdutosCommand = new Command(ListarProdutos);
            ListaPedidosCommand = new Command(ListarPedidos);
        }
        
        private async void GoToHome()
        {
            await NavigationService.NavigateToHome();
        }

        private async void ListarPedidos()
        {
            await NavigationService.NavigateToPedidos();
        }

        private async void ListarProdutos()
        {
            await NavigationService.NavigateToProdutos();
        }
    }
}