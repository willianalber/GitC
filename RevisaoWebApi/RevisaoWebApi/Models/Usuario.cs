using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models
{
    public class Usuario : UserControl
    {
        [Key]
        public int Id { get; set; }

        [CustomValidFilds(Enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }

        [CustomValidFilds(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

        [CustomValidFilds(Enums.ValidFields.ValidaLogin)]
        public string login { get; set; }

        [CustomValidFilds(Enums.ValidFields.ValidaSenha)]
        public string senha { get; set; }

    }
}