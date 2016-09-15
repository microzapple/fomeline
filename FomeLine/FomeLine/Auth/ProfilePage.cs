using Xamarin.Forms;

namespace FomeLine.Auth
{
    public class ProfilePage : BasePage //It is to ensure nothing to display before logging in.
    {
        public ProfilePage()
        {
            Content = new Label()
            {
                Text = "Perfil",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }
}