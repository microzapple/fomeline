using System.Threading.Tasks;
using FomeLine.ViewModels.Interfaces;
using FomeLine.Views;
using FomeLine.Views.Account;
using FomeLine.Views.Pedidos;
using FomeLine.Views.Produtos;
using Xamarin.Forms;

namespace FomeLine.Services
{
    public class NavigationService : INavigationService
    {
        private readonly string _appName = "FomeLine";

        public async Task NavigateToLogin()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView {Title = "Login"});
        }

        public async Task NavigateToRegister()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new RegisterView {Title = "Registrar"}));
        }

        public async Task NavigateToMain()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new HomeView {Title = _appName}));
        }

        public async Task NavigateToHome()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new HomeView {Title = _appName}));
        }

        public async Task NavigateToPedidos()
        {
            await
                Application.Current.MainPage.Navigation.PushModalAsync(
                    new NavigationPage(new ListaPedidoView {Title = "Pedidos"}));
        }

        public async Task NavigateToAddPedido()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AddPedidoView {Title = "Adicionar Pedido"}));
        }

        public async Task NavigateToProdutos()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ListaProdutosView { Title = "Produtos" }));
        }

        public async Task NavigateToAddProduto()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AddProdutoView {Title = "Adicionar Produto"}));
        }
    }
}