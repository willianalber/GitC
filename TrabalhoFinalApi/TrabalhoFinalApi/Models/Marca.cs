using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class Marca : PropUteis
    {
        [Key]
        //public int Id { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Descricao { get; set; } = "N/A";

        /*[ForeignKey("IDTipoVeiculo")]
        public virtual TipoVeiculo TipoVeiculo { get; set; } 
        [Required]
        //[Key, Column(Order = 0)]*/
        public int IDTipoVeiculo { get; set; }
    }
}