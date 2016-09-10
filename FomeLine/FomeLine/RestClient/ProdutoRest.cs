using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using FomeLine.Models;
using Newtonsoft.Json;

namespace FomeLine.RestClient
{
   public  class ProdutoRest
    {
        private const string UrlService = "http://localhost/fomeline/api/pedido/";
       private static readonly string UrlListaProdutos = string.Format("{0}GetAll", UrlService);

        public async Task<List<Produto>> GetAllAsync()
        {
            try
            {
                var httpClient = new HttpClient();
                var json = await httpClient.GetStringAsync(UrlListaProdutos);
                
                var products = JsonConvert.DeserializeObject<List<Produto>>(json);
                return products;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
                return null;
            }
        }
        
    }
}