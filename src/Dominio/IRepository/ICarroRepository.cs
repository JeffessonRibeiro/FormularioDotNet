using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepository
{
    public interface ICarroRepository
    {
        Task Adicionar(Carro carro);
        Task Editar(Carro carro);
        Task Delete(Carro carro);
        Task<Carro> BuscarId(Guid id);
        Task<IEnumerable<Carro>> BuscarTodos();

    }
}
