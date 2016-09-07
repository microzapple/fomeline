using System.Windows.Input;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class LoginVm : BaseVm
    {
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                Notify(nameof(Email));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                Notify(nameof(Password));
            }
        }

        public ICommand LoginCommand
        {
            get;
            set;
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }

        public LoginVm()
        {
            LoginCommand = new Command(Login);
            RegisterCommand = new Command(Register);
        }

        private async void Login()
        {
            //if (Email == "adm" && Password == "123")
            //{
            //    await NavigationService.NavigateToMain();
            //}
            //else
            //{
            //    await MessageService.ShowAsync("Email e/ou Senha inválidos...");
            //}

            await MessageService.ShowAsync("Login e/ou Senha inválidos...");
        }

        private async void Register()
        {
            await NavigationService.NavigateToRegister();
        }
    }
}