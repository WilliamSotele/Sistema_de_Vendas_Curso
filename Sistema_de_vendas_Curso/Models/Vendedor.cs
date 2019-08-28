using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_vendas_Curso.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVendas> Registro { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime nascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            Nascimento = nascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendas rg)
        {
            Registro.Add(rg);
        }
        public void RemoveVenda(RegistroVendas rg)
        {
            Registro.Remove(rg);
        }
        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Registro.Where(rg => rg.Data >= inicio && rg.Data <= final).Sum(rg => rg.Total);
        }
    }
}
