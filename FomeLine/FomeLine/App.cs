using FomeLine.Services;
using FomeLine.ViewModels.Interfaces;
using FomeLine.Views;
using FomeLine.Views.Menu;
using FomeLine.Views.Produtos;
using Xamarin.Forms;

namespace FomeLine
{
    public class App : Application
    {
        public App()
        {
            DependencyService.Register<IMessageService, MessageService>();
            DependencyService.Register<INavigationService, NavigationService>();

            MainPage = new MasterMenuView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}