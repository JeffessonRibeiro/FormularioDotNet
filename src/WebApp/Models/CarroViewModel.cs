using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class CarroViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Invalido")]
        public string Modelo { get; set; }
        public int QuantidePortas { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
       
    }
}
