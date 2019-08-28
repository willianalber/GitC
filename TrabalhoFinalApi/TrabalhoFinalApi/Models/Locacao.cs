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


        [ForeignKey("IdVeiculo")]
        public Veiculo fk_Locacao_Veiculo { get; set; }
        [Required]
        public int IdVeiculo { get; set; }


        [ForeignKey("IdPeriodoLocacao")]
        public PeriodoLocacao fk_Locacao_PeriodoLocacao { get; set; }
        [Required]
        public int IdPeriodoLocacao { get; set; }


        [ForeignKey("IdUsuarioLocacao")]
        public UsuarioLocador fk_Locacao_UsuarioLocacao { get; set; }
        [Required]
        public int IdUsuarioLocacao { get; set; }


        [ForeignKey("IdTermoLocacao")]
        public TermoLocacao fk_Locacao_TermoLocacao { get; set; }
        [Required]
        public int IdTermoLocacao { get; set; }


        [ForeignKey("IdSituacao")]
        public Situacao fk_Locacao_Situacao { get; set; }
        [Required]
        public int IdSituacao { get; set; }
    }
}