using System;
using System.Collections.Generic;
using System.Linq;
using FomeLine.Models;

namespace FomeLine.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, IDisposable
    {
        public List<Produto> GetByName(string name)
        {
           return Conexao.Table<Produto>().Where(x => x.Nome.Contains(name)).ToList();
        }
    }
}