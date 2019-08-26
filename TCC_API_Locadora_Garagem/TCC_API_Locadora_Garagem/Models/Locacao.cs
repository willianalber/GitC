using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace TCC_API_Locadora_Garagem.Models
{
    public class Locacao : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        //[Required] 
        [ForeignKey("Id")]
        public TipoVeiculo IdTipoVeiculo { get; set; }
        //[Required]
        [ForeignKey("Id")]
        public Marca IdMarca { get; set; }
        //[Required]
        [ForeignKey("Id")]
        public Modelo IdModelo { get; set; }
        //[Required]
        [ForeignKey("Id")]
        public Cor IdCor { get; set; }
        //[Required]
        public string Placa { get; set; }
        //[Required]
        public bool AceiteTermo { get; set; }
        public int Situacao { get; set; } = 1;
    }
}