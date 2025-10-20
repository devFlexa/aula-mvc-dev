using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula_mvc.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {

            var contatos = new List<Contato>
            {
                new Contato { Id = 1, Nome = "Maria", Telefone = "1111-1111", Ativo = true },
                new Contato { Id = 2, Nome = "João", Telefone = "2222-2222", Ativo = false },
                new Contato { Id = 3, Nome = "Ana", Telefone = "3333-3333", Ativo = true }
            };

            return View(contatos);
        }
    }
}