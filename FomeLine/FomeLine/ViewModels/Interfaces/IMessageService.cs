using System.Threading.Tasks;

namespace FomeLine.ViewModels.Interfaces
{
    public interface IMessageService
    {
        Task ShowAsync(string message);
        Task ShowAsync(string title, string message);
    }
}