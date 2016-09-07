using System.ComponentModel;
using System.Windows.Input;
using FomeLine.ViewModels.Interfaces;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public abstract class BaseVm : INotifyPropertyChanged
    {
        protected IMessageService MessageService;
        protected INavigationService NavigationService;
        public ICommand HomeCommand { get; set; }

        protected BaseVm()
        {
            MessageService = DependencyService.Get<IMessageService>();
            NavigationService = DependencyService.Get<INavigationService>();
            HomeCommand = new Command(GoHome);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void GoHome()
        {
            await NavigationService.NavigateToHome();
        }
    }
}