using System.Collections.Generic;
using System.Threading.Tasks;
using FomeLine.Models;
using Plugin.RestClient;

namespace FomeLine.ViewModels
{
    public class ListaProdutoVm : BaseVm
    {
        private List<Produto> _listaProdutos;
        public List<Produto> ListaProdutos
        {
            get { return _listaProdutos; }
            set
            {
                _listaProdutos = value;
                Notify(nameof(ListaProdutos));
            }
        }

        public ListaProdutoVm()
        {
            Listar();
        }

        public async Task Listar()
        {
            var api = new RestClient<Produto>();
            var pr = new Produto();
            pr.SetInformation("Pizza M", "icon.png", 12);

            ListaProdutos = new List<Produto>
            {
                pr,
                pr,
                pr,
                pr,
                pr,
                pr
            };
            //ListaProdutos = await api.GetProductsAsync();
        }
    }
}