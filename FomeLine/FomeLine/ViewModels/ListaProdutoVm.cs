using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FomeLine.Models;
using FomeLine.Services;

namespace FomeLine.ViewModels
{
    public class ListaProdutoVm : Produto
    {
        private ObservableCollection<Produto> _listaEntities;

        public ObservableCollection<Produto> Lista
        {
            get
            {
                if (_listaEntities == null) Listar();
                return _listaEntities;
            }
            set { _listaEntities = value; }
        }

        public void Listar()
        {
            using (var context = new ProdutoService())
            {
                var list = new ObservableCollection<Produto>(context.GetAll());
                _listaEntities = list;
            }
        }
    }
}