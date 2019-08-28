using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_vendas_Curso.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {
        }

        public RegistroVendas(int id, DateTime data, double total, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Vendedor = vendedor;
        }

        
    }
}
