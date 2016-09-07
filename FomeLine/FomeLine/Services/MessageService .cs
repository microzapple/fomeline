using System.Threading.Tasks;
using FomeLine.ViewModels.Interfaces;
using Xamarin.Forms;

namespace FomeLine.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string message)
        {
            await Application.Current.MainPage.DisplayAlert("FomeLine", message, "OK");
        }

        public async Task ShowAsync(string title, string message)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, "OK");
        }
    }
}