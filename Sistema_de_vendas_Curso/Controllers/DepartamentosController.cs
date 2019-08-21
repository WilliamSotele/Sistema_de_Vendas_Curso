using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_vendas_Curso.Models;

namespace Sistema_de_vendas_Curso.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento (1,"Eletrônicos"));
            lista.Add(new Departamento(2, "Ferramentas"));
            lista.Add(new Departamento(3, "Plasticificados"));

            return View(lista);
        }
    }
}