using Dominio.IRepository;
using Historia.Carros;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApp.Factories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class CarroController : Controller
    {
        private readonly ConsultarCarro _consultarCarro;

        private readonly AdicionarCarro _adicionarCarro;
        public CarroController(ICarroRepository carroRepository)
        {
            _adicionarCarro = new AdicionarCarro(carroRepository);
            _consultarCarro = new ConsultarCarro(carroRepository);
        }
        public async Task<IActionResult> Index()
        {
            var listaCarros = await _consultarCarro.BuscarTodos();
            var listaCarrosViewModel = CarroFactory.MapearLista(listaCarros);
            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(CarroViewModel carroViewModel)
        {
            if (ModelState.IsValid)
            {
                var carro = CarroFactory.MapearParaEntidadeCarro(carroViewModel);
                await _adicionarCarro.Executar(carro);
                return RedirectToAction("Index");
            }
            return View(carroViewModel);
        }
        
        public IActionResult Editar(Guid id)
        {
            return View();
        }

    }

}
