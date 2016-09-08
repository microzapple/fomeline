using System;
using System.Windows.Input;
using FomeLine.Services;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class PedidoVm : BaseVm
    {
        private int _pedidoId;
        public int PedidoId
        {
            get
            {
                return _pedidoId;
            }
            set
            {
                _pedidoId = value;
                Notify(nameof(PedidoId));
            }
        }

        private DateTime _data;
        public DateTime Data
        {
            get { return _data; }
            set
            {
                _data = value;
                Notify(nameof(Data));
            }
        }

        private int _usuarioId;
        public int UsuarioId
        {
            get { return _usuarioId; }
            set
            {
                _usuarioId = value;
                Notify(nameof(UsuarioId));
            }
        }

        public ICommand NovoPedidoCommand { get; set; }
        public ICommand ListaPedidosCommand { get; set; }
        public ICommand ListaProdutosCommand { get; set; }
        public ICommand GravarCommand { get; set; }

        public PedidoVm()
        {
            GravarCommand = new Command(GoToGravar);
            ListaPedidosCommand = new Command(GoToListarPedidos);
            ListaProdutosCommand = new Command(GoToListarProdutos);
            NovoPedidoCommand = new Command(GoToNovoPedido);
        }

        public async void GoToGravar()
        {
            await MessageService.ShowAsync("Implementar");
            //await NavigationService.NavigateToPedidos();
        }

        public async void GoToListarPedidos()
        {
            await NavigationService.NavigateToPedidos();
        }

        public async void GoToListarProdutos()
        {
            var service = new ProdutoService();
            //var ss = await service.GetFromApiAsync();
            await NavigationService.NavigateToProdutos();
        }

        public async void GoToNovoPedido()
        {
            await NavigationService.NavigateToAddPedido();
        }
    }
}