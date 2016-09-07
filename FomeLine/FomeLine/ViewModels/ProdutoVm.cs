using System;
using System.Windows.Input;
using FomeLine.Models;
using FomeLine.Services;
using Xamarin.Forms;

namespace FomeLine.ViewModels
{
    public class ProdutoVm : BaseVm
    {
        private int _produtoId;
        public int ProdutoId
        {
            get { return _produtoId; }
            set
            {
                _produtoId = value;
                Notify(nameof(ProdutoId));
            }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                Notify(nameof(Nome));
            }
        }

        private string _imagem;
        public string Imagem
        {
            get { return _imagem; }
            set
            {
                _imagem = value;
                Notify(nameof(Imagem));
            }
        }

        private decimal _valor;
        public decimal Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
                Notify(nameof(Valor));
            }
        }

        public ICommand ListaPedidosCommand { get; set; }
        public ICommand NovoProdutoCommand { get; set; }
        public ICommand GravarCommand { get; set; }
        public ProdutoVm()
        {
            ListaPedidosCommand = new Command(GoToListarPedidos);
            NovoProdutoCommand = new Command(GoToNovoProduto);
            GravarCommand = new Command(Gravar);
        }

        public async void Gravar()
        {
            try
            {
                var product = new Produto();
                product.SetInformation(Nome, Imagem, Valor);

                var service = new ProdutoService();
                service.Insert(product);

                await MessageService.ShowAsync("Produto gravado com sucesso!");
            }
            catch (Exception error)
            {
                await MessageService.ShowAsync(error.Message);
            }
        }
        
        public async void GoToListarPedidos()
        {
            await NavigationService.NavigateToPedidos();
        }
        
        public async void GoToNovoProduto()
        {
            await NavigationService.NavigateToAddProduto();
        }
    }
}