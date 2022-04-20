using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Carro
    {
        public Carro( string modelo, int quantidadePortas, string marca, int ano)
        {
            Id = Guid.NewGuid();
            Modelo = modelo;
            QuantidadePortas = quantidadePortas;
            Marca = marca;
            Ano = ano;
        }

        public Guid Id { get; private set; }
        public string Modelo { get; private set; }
        public int QuantidadePortas { get; private set; }
        public string Marca { get; private set; }
        public int Ano { get; private set; }
    }
}
