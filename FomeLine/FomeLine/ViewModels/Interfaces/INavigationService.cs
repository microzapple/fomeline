using System.Threading.Tasks;

namespace FomeLine.ViewModels.Interfaces
{
    public interface INavigationService
    {
        Task NavigateToLogin();
        Task NavigateToRegister();
        Task NavigateToMain();
        Task NavigateToHome();
        Task NavigateToPedidos();
        Task NavigateToAddPedido();
        Task NavigateToProdutos();
        Task NavigateToAddProduto();
    }
}