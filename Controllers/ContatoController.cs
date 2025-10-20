using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aula_mvc.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}