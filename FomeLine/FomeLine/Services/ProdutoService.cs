using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FomeLine.Helpers;
using FomeLine.Models;
using FomeLine.Repository;
using FomeLine.RestClient;

namespace FomeLine.Services
{
    public class ProdutoService : ProdutoRepository
    {
        public override void Insert(Produto entity)
        {
            if (!entity.IsValid()) throw new Exception("Informações Incorretas");
            base.Insert(entity);
        }

        public override void Update(Produto entity)
        {
            if (!entity.IsValid()) throw new Exception("Informações Incorretas");
            base.Update(entity);
        }

        public async Task<List<Produto>> GetAllFromApiAsync()
        {
            try
            {
                var api = new ProdutoRest();
                var products = await api.GetAllAsync();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Group<string, Produto>> Group(List<Produto> list, string search = "")
        {
            if (!string.IsNullOrEmpty(search))
                list = list.Where(x => x.Nome.ToLower().Contains(search.ToLower())).ToList();

            var result = from prod in list
                         orderby prod.Nome
                         group prod by prod.Nome into grupos
                         select new Group<string, Produto>(grupos.Key, grupos);

            var enumerable = result as Group<string, Produto>[] ?? result.ToArray();
            return enumerable;
        }

    }
}