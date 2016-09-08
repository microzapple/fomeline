using System;
using System.Collections.Generic;
using System.Linq;
using FomeLine.Helpers;
using FomeLine.Models;
using Xamarin.Forms;

namespace FomeLine.Views
{
    public partial class ListGroupView : ContentPage
    {
        private readonly List<Produto> _products = new List<Produto>();

        public ListGroupView()
        {
            InitializeComponent();

            var pro = new Produto { ProdutoId = 1 };
            pro.SetInformation("Pizza G", "icon.png", 12);
            _products.Add(pro);

            var pro2 = new Produto { ProdutoId = 2 };
            pro2.SetInformation("Pizza PP", "icon.png", 32);  
            _products.Add(pro2);

            var pro3 = new Produto { ProdutoId = 1 };
            pro3.SetInformation("Pizza XG", "icon.png", 20);
            _products.Add(pro3);

            var pro4 = new Produto { ProdutoId = 1 };
            pro4.SetInformation("Pizza M", "icon.png", 28);
            _products.Add(pro4);

            var pro5 = new Produto { ProdutoId = 1 };
            pro5.SetInformation("Pizza XP", "icon.png", 12);
            _products.Add(pro5);

            busca.TextChanged += Busca_TextChaged;
            this.lista.ItemsSource = Listar();
        }

        private void Busca_TextChaged(object sender, TextChangedEventArgs e)
        {
            lista.ItemsSource = Listar(busca.Text);
        }

        public IEnumerable<Group<string, Produto>> Listar(string search = "")
        {
            try
            {
                IEnumerable<Produto> list = _products;
                if (!string.IsNullOrEmpty(search))
                    list = list.Where(x => x.Nome.ToLower().Contains(search.ToLower())).ToList();

                var result = from prod in list
                             orderby prod.Nome
                             group prod by prod.Nome
                    into grupos
                    select new Group<string, Produto>(grupos.Key, grupos);

                var enumerable = result as Group<string, Produto>[] ?? result.ToArray();
                return enumerable;
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
                return null;
            }
        }
    }
}