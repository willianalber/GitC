using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class Colaborador : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool TemPcd { get; set; }
        public bool TrabalhaNoturno { get; set; }
    }
}