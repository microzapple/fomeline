using System.Windows.Input;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class HomeVm : BaseVm
    {
        public ICommand ListaProdutosCommand { get; set; }
        public ICommand ListaPedidosCommand { get; set; }

        public HomeVm()
        {
            HomeCommand = new Command(GoToHome);
            ListaProdutosCommand = new Command(GoToListarProdutos);
            ListaPedidosCommand = new Command(GoToListarPedidos);
        }
        
        private async void GoToHome()
        {
            await NavigationService.NavigateToHome();
        }

        private async void GoToListarPedidos()
        {
            await NavigationService.NavigateToPedidos();
        }

        private async void GoToListarProdutos()
        {
            await NavigationService.NavigateToProdutos();
        }
    }
}