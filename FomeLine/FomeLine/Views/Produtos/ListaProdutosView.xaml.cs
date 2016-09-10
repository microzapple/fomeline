using System;
using System.Collections.Generic;
using FomeLine.Helpers;
using FomeLine.Models;
using FomeLine.Services;
using FomeLine.ViewModels.Interfaces;
using Xamarin.Forms;

namespace FomeLine.Views.Produtos
{
    public partial class ListaProdutosView : ContentPage
    {
        private readonly List<Produto> _products;
        private readonly ProdutoService _service = new ProdutoService();
        protected IMessageService MessageService;

        public ListaProdutosView()
        {
            InitializeComponent();

            MessageService = DependencyService.Get<IMessageService>();
            _products = _service.GetAll();
            busca.TextChanged += Busca_TextChaged;
            lista.ItemsSource = Group();
        }

        private void Busca_TextChaged(object sender, TextChangedEventArgs e)
        {
            lista.ItemsSource = Group(busca.Text);
        }

        public IEnumerable<Group<string, Produto>> Group(string search = "")
        {
            try
            {
                return _service.Group(_products);
            }
            catch (Exception ex)
            {
                MessageService.ShowAsync("Erro", ex.Message);
                return null;
            }
        }

        private void SelecionarCommand(object sender, ItemTappedEventArgs e)
        {
            var per = e.Item as Produto;
            MessageService.ShowAsync("Selecionado", per.Nome);
        }
    }
}