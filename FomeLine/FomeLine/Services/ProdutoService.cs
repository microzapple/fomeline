using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FomeLine.Models;
using FomeLine.Repository;
using Plugin.RestClient;

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

        public async Task<List<Produto>> GetFromApiAsync()
        {
            try
            {
                var api = new RestClient<Produto>();
                var products = await api.GetProductsAsync();
                return products;
            }
            catch (System.Exception error)
            {
                var sss = error.Message;
                throw;
            }
        }
    }
}