using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepository
{
    public interface ICarroRepository
    {
        Task<Carro> Adicionar(Carro carro);
        Task<Carro> Editar(Carro carro);
        Task Delete(Carro carro);
        Task<Carro> BuscarId(Guid id);
        Task<IEnumerable<Carro>> BuscarTodos();

    }
}
