using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class TipoVeiculo : PropUteis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}