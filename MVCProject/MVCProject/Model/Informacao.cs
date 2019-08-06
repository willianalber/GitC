﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Model
{
    public class Informacao
    {
        public bool Ativo { get; set; } = true;
        public int UsuInc { get; set; } 
        public int UsuAlt { get; set; } 
        public DateTime DataInc { get; set; } = DateTime.Now;
        public DateTime DataALt { get; set; } = DateTime.Now;
    }
}
