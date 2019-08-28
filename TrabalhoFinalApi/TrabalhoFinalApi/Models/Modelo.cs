using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class Modelo : PropUteis
    {
        [Key]
        public int Id { get; set; }        
        [Required]
        public string Descricao { get; set; }
        /*[ForeignKey("IDMarca")]
        public Marca Marca { get; set; }*/
        public int IDMarca { get; set; }
        public int IDTipoVeiculo { get; set; }
    }
}