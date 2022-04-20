using System;

namespace WebApp.Models
{
    public class CarroViewModel
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public int QuantidePortas { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
       
    }
}
