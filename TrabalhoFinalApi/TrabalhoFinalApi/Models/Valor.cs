using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class Valor : PropUteis
    {
        [Key]
        public int Id { get; set; }        
        [Required]
        public int IdPeriodoLocacao { get; set; }
    }
}