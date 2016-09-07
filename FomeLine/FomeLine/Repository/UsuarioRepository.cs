using System;
using FomeLine.Models;
using System.Linq;

namespace FomeLine.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IDisposable
    {
        public Usuario Authenticate(string userName, string password)
        {
            return Conexao.Table<Usuario>().FirstOrDefault(f => f.UserName.Equals(userName) && f.Password.Equals(password));
        }

        public Usuario GetById(int id)
        {
            return Conexao.Table<Usuario>().FirstOrDefault(f => f.UsuarioId.Equals(id));
        }

        public Usuario GetByUserName(string userName)
        {
            return Conexao.Table<Usuario>().FirstOrDefault(f => f.UserName.Equals(userName));
        }

        public Usuario GetByEmail(string email)
        {
            return Conexao.Table<Usuario>().FirstOrDefault(f => f.Email.Equals(email));
        }

        public bool IsUniqueEmail(string email)
        {
            return !Conexao.Table<Usuario>().Any(a => a.Email.Equals(email));
        }

        public bool IsUniqueUserName(string userName)
        {
            return !Conexao.Table<Usuario>().Any(a => a.UserName.Equals(userName));
        }
    }
}