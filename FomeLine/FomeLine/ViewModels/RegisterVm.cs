using System;
using System.Windows.Input;
using FomeLine.Models;
using FomeLine.Services;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class RegisterVm : BaseVm
    {
        private int _usuarioId;
        public int UsuarioId
        {
            get
            {
                return _usuarioId;
            }
            set
            {
                _usuarioId = value;
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
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;
                Notify(nameof(ConfirmPassword));
            }
        }

        public ICommand RegisterCommand
        {
            get;
            set;
        }

        public RegisterVm()
        {
            RegisterCommand = new Command(Register);
        }

        private async void Register()
        {
            try
            {
                var user = new Usuario();
                user.SetInformation(_email, _userName, _password, _confirmPassword, _firstName, _lastName);

                var service = new UsuarioService();
                service.Insert(user);
                await NavigationService.NavigateToLogin();
            }
            catch (Exception error)
            {
                await MessageService.ShowAsync(error.Message);
            }
        }
    }
}