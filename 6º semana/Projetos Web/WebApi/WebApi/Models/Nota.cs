namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nota
    {
        public int id { get; set; }

        public int aluno { get; set; }

        [Column("Nota")]
        public int Nota1 { get; set; }

        public virtual Aluno Aluno1 { get; set; }
    }
}
