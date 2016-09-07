using System;
using System.Threading;
using SQLite.Net.Attributes;

namespace FomeLine.Models
{
    public class Produto
    {
        public Produto() { }

        [PrimaryKey, AutoIncrement]
        public int ProdutoId { get; set; }

        public string Nome { get; private set; }

        public string Imagem { get; private set; }

        public decimal Valor { get; private set; }

        public void SetInformation(string nome, string imagem, decimal valor)
        {
            Nome = nome;
            Imagem = imagem;
            Valor = valor;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Nome)) throw new Exception("Nome Obrigatório");
            if (string.IsNullOrEmpty(Imagem)) throw new Exception("Imagem Obrigatório");
            if (Valor == 0) throw new Exception("Valor Obrigatório");
            return true;
        }
    }
}