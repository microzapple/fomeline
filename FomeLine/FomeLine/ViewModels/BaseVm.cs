using System.ComponentModel;
using FomeLine.ViewModels.Interfaces;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public abstract class BaseVm : INotifyPropertyChanged
    {
        protected IMessageService MessageService;
        protected INavigationService NavigationService;

        protected BaseVm()
        {
            MessageService = DependencyService.Get<IMessageService>();
            NavigationService = DependencyService.Get<INavigationService>();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected void Notify(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}