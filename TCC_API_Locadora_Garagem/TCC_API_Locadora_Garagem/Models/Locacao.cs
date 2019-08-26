using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class Locacao : PropriedadesUteis
    {
        [Key]
        public int Id { get; set; }
        public int IdTipoVeiculo { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public int IdCor { get; set; }
        public string Placa { get; set; }
        public bool AceiteTermo { get; set; }
        public bool Situacao { get; set; }
    }
}