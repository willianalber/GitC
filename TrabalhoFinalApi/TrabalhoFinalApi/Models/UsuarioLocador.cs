using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class UsuarioLocador : PropUteis
    {
        [Key]
        public int Id { get; set; }        
        [ForeignKey("IdColaborador")]
        public Colaborador Colaborador { get; set; }
        [Required]
        public int IdColaborador { get; set; }
        public bool ResideFora { get; set; } = false;
        public bool OfereceCarona { get; set; } = false;
    }
}