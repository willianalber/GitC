using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class PeriodoLocacao : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        public int IDTipoVeiculo { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int QtdVagas { get; set; }
    }
}