using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
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


    }
}