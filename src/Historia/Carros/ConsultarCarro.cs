using Dominio.Entidade;
using Dominio.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Carros
{
    public class ConsultarCarro
    {
        private readonly ICarroRepository _carroRepository;

        public ConsultarCarro(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }
        public async Task<IEnumerable<Carro>> BuscarTodos()
        {
            return await _carroRepository.BuscarTodos();
        }
    }
}
