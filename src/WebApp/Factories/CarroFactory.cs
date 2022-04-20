using Dominio.Entidade;
using WebApp.Models;

namespace WebApp.Factories
{
    public static class CarroFactory
    {
        public static Carro MapearParaEntidadeCarro(CarroViewModel model)
        {
            Carro carro = new Carro(
                model.Modelo,
                model.QuantidePortas,
                model.Marca,
                model.Ano                
                ); 
            return carro;
        } 
    }
}
