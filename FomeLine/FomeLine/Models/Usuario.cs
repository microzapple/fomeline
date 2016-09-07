using System;
using FomeLine.Helpers;
using SQLite.Net.Attributes;

namespace FomeLine.Models
{
    public class Usuario
    {
        public Usuario() { }
        public void SetInformation(string email, string userName, string password, string confirmPassword, string firstName, string lastName)
        {
            Email = email;
            UserName = userName;
            Password = password;
            ConfirmPassword = confirmPassword;
            FirstName = firstName;
            LastName = lastName;
            Ativo = true;
            DataCadastro = DateTime.Now;
        }
        
        [PrimaryKey, AutoIncrement]
        public int UsuarioId { get; set; }

        [MaxLength(60), Unique]
        public string Email { get; private set; }

        [MaxLength(14), Unique]
        public string UserName { get; private set; }

        [MaxLength(100)]
        public string Password { get; private set; }

        [MaxLength(30)]
        public string FirstName { get; private set; }

        [MaxLength(30)]
        public string LastName { get; private set; }

        public bool Ativo { get; private set; }
        public DateTime DataCadastro { get; private set; }

        [Ignore]
        public string ConfirmPassword { get; private set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(FirstName)) throw new Exception("Nome Obrigat�rio");
            if (string.IsNullOrEmpty(LastName)) throw new Exception("Sobrenome Obrigat�rio");
            if (string.IsNullOrEmpty(Email)) throw new Exception("Email Obrigat�rio");
            if (string.IsNullOrEmpty(UserName)) throw new Exception("Login Obrigat�rio");
            if (string.IsNullOrEmpty(Password)) throw new Exception("Senha Obrigat�rio");
            if (string.IsNullOrEmpty(ConfirmPassword)) throw new Exception("Confirma��o de Senha Obrigat�rio");
            if(!ConfirmPassword.Equals(Password)) throw new Exception("Senha e Confirma��o n�o confere!");
            if(!EmailHelper.IsEmail(Email)) throw  new Exception("Email inv�lido!");
            return true;
        }
    }
}