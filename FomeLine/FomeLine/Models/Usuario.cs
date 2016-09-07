using System;
using SQLite.Net.Attributes;

namespace FomeLine.Models
{
    public class Usuario
    {
        public Usuario(string email, string userName, string password, string confirmPassword, string firstName, string lastName)
        {
            Email = email;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Ativo = true;
            DataCadastro = DateTime.Now;
            ConfirmPassword = confirmPassword;
        }

        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }

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
            return true;
        }
    }
}