using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TCC_API_Locadora_Garagem.Models
{
    public class BaseDeDados : DbContext
    {
        public DbSet<TipoVeiculo> tipoVeiculos { get; set; }
    }
}