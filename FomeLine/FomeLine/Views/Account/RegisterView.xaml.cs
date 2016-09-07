using FomeLine.ViewModels;
using Xamarin.Forms;

namespace FomeLine.Views.Account
{
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();
            BindingContext = new RegisterVm();
        }
    }
}