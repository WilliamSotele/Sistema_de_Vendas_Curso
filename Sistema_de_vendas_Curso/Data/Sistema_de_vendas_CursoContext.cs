using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_vendas_Curso.Models
{
    public class Sistema_de_vendas_CursoContext : DbContext
    {
        public Sistema_de_vendas_CursoContext (DbContextOptions<Sistema_de_vendas_CursoContext> options)
            : base(options)
        {
        }

        public DbSet<Sistema_de_vendas_Curso.Models.Departamento> Departamento { get; set; }
    }
}
