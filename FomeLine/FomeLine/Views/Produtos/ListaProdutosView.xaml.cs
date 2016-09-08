using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FomeLine.Helpers;
using FomeLine.Models;
using FomeLine.ViewModels;
using FomeLine.ViewModels.Interfaces;
using Xamarin.Forms;

namespace FomeLine.Views.Produtos
{
    public partial class ListaProdutosView : ContentPage
    {
        protected IMessageService MessageService;

        public ListaProdutosView()
        {
            InitializeComponent();

            MessageService = DependencyService.Get<IMessageService>();
            BindingContext = new ProdutoVm();
        }

        private void SelecionarCommand(object sender, ItemTappedEventArgs e)
        {
            var per = e.Item as Produto;
            MessageService.ShowAsync("Selecionado", per.Nome);
        }
    }
}