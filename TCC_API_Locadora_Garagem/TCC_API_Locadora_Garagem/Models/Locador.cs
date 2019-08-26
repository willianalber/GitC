using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class Locador : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        public int IdColaborador { get; set; }
        public bool OfereceCarona { get; set; }
        public bool ResideFora { get; set; }

    }
}