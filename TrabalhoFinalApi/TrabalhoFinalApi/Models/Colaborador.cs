using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class Colaborador : PropUteis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        public bool Pcd { get; set; } = false;
        public bool TrabalhaNoturno { get; set; } = false;
        [Required]
        public DateTime DataNascimento { get; set; }
    }
}