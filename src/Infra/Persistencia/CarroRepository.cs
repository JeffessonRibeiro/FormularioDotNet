using Dominio.Entidade;
using Dominio.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class CarroRepository : ICarroRepository
    {
        public Task<Carro> Adicionar(Carro carro)
        {
            throw new NotImplementedException();
        }

        public Task<Carro> BuscarId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Carro>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task Delete(Carro carro)
        {
            throw new NotImplementedException();
        }

        public Task<Carro> Editar(Carro carro)
        {
            throw new NotImplementedException();
        }
    }
}
