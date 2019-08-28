using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class PeriodoLocacao : PropUteis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("IdTipoVeiculo")]
        public virtual TipoVeiculo TipoVeiculo { get; set; }
        public int IdTipoVeiculo { get; set; }
        [Required]
        public DateTime DataInicio { get; set; } = DateTime.Now;
        [Required]
        public DateTime DataFinal { get; set; } = DateTime.Now;
    }
}