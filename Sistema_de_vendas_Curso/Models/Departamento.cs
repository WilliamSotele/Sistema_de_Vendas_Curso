using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_vendas_Curso.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
