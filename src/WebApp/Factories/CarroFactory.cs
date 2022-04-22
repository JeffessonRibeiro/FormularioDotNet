using Dominio.Entidade;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Factories
{
    public static class CarroFactory
    {
        public static Carro MapearParaEntidadeCarro(CarroViewModel model)
        {
            Carro carro = new(
                model.Modelo,
                model.QuantidePortas,
                model.Marca,
                model.Ano                
                ); 

            return carro;
        } 
        public static CarroViewModel MapearParaCarroViewModel(Carro carro)
        {
            var carroViewModel = new CarroViewModel
            {
                Id = carro.Id,
                Modelo = carro.Modelo,
                QuantidePortas = carro.QuantidadePortas,
                Marca = carro.Marca,
                Ano = carro.Ano

            };
            return carroViewModel;

        }
        public static IEnumerable<CarroViewModel> MapearLista(IEnumerable<Carro> carros)
        {
            var lista = new List<CarroViewModel>();
            foreach (var carro in carros)
            {
                lista.Add(MapearParaCarroViewModel(carro));

            }
            return lista;
        }
    }
}
