using System;
using System.Net.Http;
using System.Threading.Tasks;
using FomeLine.Models;
using FomeLine.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        public async void GetAllFromApi()
        {
            try
            {


                var client = new HttpClient();
                var ddd = client.GetAsync("http://localhost/Pizzaria/api/services/GetUnidadeDeMedidas/7");
                var ddssd = client.GetStreamAsync("http://localhost/Pizzaria/api/services/GetUnidadeDeMedidas/7");
                var ssss = ddd.Result;
                var ssssss = ddd.IsCompleted;
                var xxx = await client.GetStringAsync("http://localhost/Pizzaria/api/services/GetUnidadeDeMedidas/7");
                JObject response = JsonConvert.DeserializeObject<dynamic>(xxx);
                var items = response.Values<JArray>("items");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}