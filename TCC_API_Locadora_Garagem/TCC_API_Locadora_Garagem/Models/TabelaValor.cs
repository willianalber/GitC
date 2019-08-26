using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class TabelaValor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; }
        [Required]
        public Decimal Valor { get; set; }
    }
}