using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApp.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
        
        public IActionResult Editar(Guid id)
        {
            return View();
        }
    }

}
