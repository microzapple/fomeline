using System;
using FomeLine.Models;
using FomeLine.Repository;

namespace FomeLine.Services
{
    public class UsuarioService : UsuarioRepository
    {
        public override void Insert(Usuario user)
        {
            if (!user.IsValid()) throw new Exception("Informações Incorretas");

            var isUniqueEmail = IsUniqueEmail(user.Email);
            if (!isUniqueEmail) throw new Exception("Email já cadastrado!");

            var isUniqueUserName = IsUniqueUserName(user.UserName);
            if (!isUniqueUserName) throw new Exception("Login já cadastrado!");

            base.Insert(user);
        }

        public override void Update(Usuario user)
        {
            if (user.IsValid()) base.Update(user);
            throw new Exception("Informações Incorretas");
        }


    }
}