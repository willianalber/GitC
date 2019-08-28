using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("IdModelo")]
        public Modelo Modelo { get; set; }
        public int IdModelo { get; set; }

        [ForeignKey("IdCor")]
        public Cor Cor { get; set; }
        public int IdCor { get; set; }
        public string Placa { get; set; }
    }
}