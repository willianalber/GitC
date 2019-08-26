using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class Modelo : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("MarcaModeloFK")]
        public Marca IdMarca { get; set; }
        public int MarcaModeloFK { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descricao { get; set; }
    }
}