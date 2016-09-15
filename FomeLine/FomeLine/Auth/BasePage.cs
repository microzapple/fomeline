using Xamarin.Forms;

namespace FomeLine.Auth
{
    public class BasePage : ContentPage
    {
        protected override void OnAppearing() // It will start immediately after the screen is appeared
        {
            base.OnAppearing();

            if (!App.IsLoggedIn) Navigation.PushModalAsync(new LoginPage());
        }
    }
}