using System;
using FomeLine.Repository.Interfaces;
using Xamarin.Forms;

namespace FomeLine.Repository
{
    public class RepositoryBase<TEntity> where TEntity : class, IDisposable
    {
        protected readonly SQLite.Net.SQLiteConnection Conexao;

        public RepositoryBase()
        {
            var config = DependencyService.Get<IDataStore>();
            Conexao = new SQLite.Net.SQLiteConnection(config.Plataform, System.IO.Path.Combine(config.Path, "FomeLine.db3"));

            Conexao.CreateTable<TEntity>();
        }

        public void Insert(TEntity entity)
        {
            Conexao.Insert(entity);
        }

        public void Delete(TEntity entity)
        {
            Conexao.Delete(entity);
        }
        
        public void Update(TEntity entity)
        {
            Conexao.Update(entity);
        }
        
        public void Dispose()
        {
            Conexao.Dispose();
        }
    }
}