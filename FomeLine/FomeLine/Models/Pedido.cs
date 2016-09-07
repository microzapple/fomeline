using System;
using SQLite.Net.Attributes;

namespace FomeLine.Models
{
   public class Pedido
    {
        [PrimaryKey, AutoIncrement]
        public int PedidoId { get; set; }
        
        public DateTime Data { get; set; }

        public int UsuarioId { get; set; }

        public decimal ValorTotal { get; private set; }

        public bool Status { get; private set; }
        
        public Pedido()
        {
            Data = DateTime.Now;
            Status = true;
        }
    }
}