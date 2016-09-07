using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Account
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginVm();
        }
    }
}