using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class Marca : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; }
        
        [ForeignKey("TipoVeiculoFK")]
        public TipoVeiculo TipoVeiculo { get; set; }
        public int TipoVeiculoFK { get; set; }


    }
}