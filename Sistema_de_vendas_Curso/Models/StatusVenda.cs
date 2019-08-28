using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_de_vendas_Curso.Models
{
    public enum StatusVenda : int
    {
        Pendente = 0,
        Faturado = 1,
        Cancelado = 2
    }
}
