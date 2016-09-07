using System.Threading.Tasks;
using FomeLine.ViewModels.Interfaces;
using FomeLine.Views;
using FomeLine.Views.Account;
using FomeLine.Views.Pedidos;
using Xamarin.Forms;

namespace FomeLine.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavigateToLogin()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new LoginView { Title = "Login" });
        }

        public async Task NavigateToRegister()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new RegisterView { Title = "Registrar" }));
        }

        public async Task NavigateToMain()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new HomeView { Title = "FomeLine" }));
        }

        public async Task NavigateToHome()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new HomeView { Title = "FomeLine" }));
        }

        public async Task NavigateToPedidos()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new ListaPedidoView { Title = "Pedidos" }));
        }

        public async Task NavigateToAddPedido()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AddPedidoView { Title = "Adicionar Pedido" }));
        }
    }
}