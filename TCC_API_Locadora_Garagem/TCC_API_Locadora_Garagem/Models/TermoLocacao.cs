using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class TermoLocacao : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }
    }
}