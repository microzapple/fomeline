using System;
using FomeLine.Models;
using FomeLine.Repository;

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

        /*
         public async void ExecuteBuscarPaciente(object obj)
        {
            try
            {
                var client = new RestClient("http://www.sistema.com.br/agendamento_online/");
                var request = new RestRequest("restapi.php", Method.POST);
                request.AddParameter("cpf", "107.927.946-64"); //parametro para metodo via POST
                request.AddParameter("status", "DadosPaciente");
                IRestResponse<Paciente> response2 = await client.Execute<Paciente>(request);
                //Pacientes.Add(response2.Data);
                Pacientes.Add(new Model.Paciente
                {
                    CdBairro = response2.Data.CdBairro,
                    CdCidade = response2.Data.CdCidade,
                    Cpf = response2.Data.Cpf,
                    Endereco = response2.Data.Endereco,
                    Nome = response2.Data.Nome,
                    NumTelefone = response2.Data.NumTelefone
                });
            }
            catch (System.Exception)
            {
                throw;
            }
            
        } */
    }
}