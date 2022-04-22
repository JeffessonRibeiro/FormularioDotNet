using Dominio.Entidade;
using Dominio.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Carros
{
    public class AdicionarCarro
    {
        private readonly ICarroRepository _carroRepository;

        public AdicionarCarro(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }
        public async Task Executar(Carro carro)
        {
           await _carroRepository.Adicionar(carro);
        }

    }
}
