using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class Locacao : PropUteis
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int IdVeiculo { get; set; }
        
        [Required]
        public int IdPeriodoLocacao { get; set; }
        
        [Required]
        public int IdColaborador { get; set; }
        
        [Required]
        public int IdTermoLocacao { get; set; }
        
        public bool ResideFora { get; set; } = false;
        public bool OfereceCarona { get; set; } = false;
        [Required]
        public int IdSituacao { get; set; }
    }
}