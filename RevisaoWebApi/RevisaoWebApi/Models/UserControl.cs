﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevisaoWebApi.Models
{
    public class UserControl
    {
        public bool Ativo { get; set; } = true;
        public int UsuarioCriacao { get; set; } = 0;
        public int UsuarioAlteracao { get; set; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}