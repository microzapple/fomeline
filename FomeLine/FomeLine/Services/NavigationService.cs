using System.Threading.Tasks;
using FomeLine.ViewModels.Interfaces;
using FomeLine.Views;
using FomeLine.Views.Account;
using FomeLine.Views.Menu;
using FomeLine.Views.Pedidos;
using FomeLine.Views.Produtos;
using Xamarin.Forms;

namespace FomeLine.Services
{
    public class NavigationService : INavigationService
    {
        private const string AppName = "FomeLine";

        public async Task NavigateToLogin()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView { Title = "Login" });
        }

        public async Task NavigateToRegister()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new RegisterView { Title = "Registrar" }));
        }

        public async Task NavigateToMain()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new MasterMenuView { Title = AppName }));
        }

        public async Task NavigateToHome()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new MasterMenuView { Title = AppName }));
        }

        public async Task NavigateToPedidos()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new ListaPedidosMenuView { Title = "Pedidos" }));
        }

        public async Task NavigateToAddPedido()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AddPedidoMenuView { Title = "Adicionar Pedido" }));
        }

        public async Task NavigateToProdutos()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ListaProdutosMenuView { Title = "Produtos" }));
        }

        public async Task NavigateToAddProduto()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AddProdutoMenuView { Title = "Adicionar Produto" }));
        }
    }
}