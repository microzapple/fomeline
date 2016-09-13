using System.Threading.Tasks;

namespace FomeLine.ViewModels.Interfaces
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
        Task ShowAsync(string title, string message);
        Task<bool> ShowConfirmationAsync(string title, string message, string accept, string cancel);
        Task<bool> ShowConfirmationAsync(string title, string message);
    }
}