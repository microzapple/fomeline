using System;
using Xamarin.Forms;

namespace FomeLine.Views.Menu
{
    public class RootPage : MasterDetailPage
    {
        private readonly MenuPage _menuPage;

        public RootPage()
        {
            _menuPage = new MenuPage();

            _menuPage.Menu.ItemSelected +=
                (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

            Master = _menuPage;
            Detail = new NavigationPage(new HomeView());
        }

        private async void NavigateTo(MenuItem menu)
        {
            if (menu == null) return;
            var displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            try
            {
                Detail = new NavigationPage(displayPage);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erro Ocorrido", ex.Message, "OK");
            }

            _menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}