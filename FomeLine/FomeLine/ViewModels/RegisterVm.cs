using System.Windows.Input;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class RegisterVm : BaseVm
    {
        private int _id;
        public int UsuarioId
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                Notify(nameof(UsuarioId));
            }
        }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                Notify(nameof(UserName));
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                Notify(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                Notify(nameof(LastName));
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                Notify(nameof(Email));
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                Notify(nameof(Password));
            }
        }

        private string _confirmPassword;
        public string ConfirmPassword
        {
            get { return ConfirmPassword; }
            set
            {
                _confirmPassword = value;
                Notify(nameof(ConfirmPassword));
            }
        }

        public RegisterVm()
        {
            RegisterCommand = new Command(Register);
        }
        private async void Register()
        {

            await MessageService.ShowAsync("Implementar ainda");
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }
    }
}