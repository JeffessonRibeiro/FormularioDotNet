using Dominio.Entidade;
using Dominio.IRepository;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencia
{
    public class CarroRepository : ICarroRepository
    {
        private readonly DataContext _DataContext;

        public CarroRepository(DataContext dataContext)
        {
            _DataContext = dataContext;
        }

        public async Task Adicionar(Carro carro)
        {
            _DataContext.Carros.Add(carro);
            await _DataContext.SaveChangesAsync();
        }
        public async Task Delete(Carro carro)
        {
            _DataContext.Carros.Remove(carro);
            await _DataContext.SaveChangesAsync();
        }

        public async Task Editar(Carro carro)
        {
            _DataContext.Carros.Update(carro);
            await _DataContext.SaveChangesAsync();
        }

        public async Task<Carro> BuscarId(Guid id)
        {
            return await _DataContext.Carros.FirstOrDefaultAsync(c => c.Id.Equals(id));
        }

        public async Task<IEnumerable<Carro>> BuscarTodos()
        {
            return await _DataContext.Carros.AsNoTracking().ToListAsync();
        }


    }
}
