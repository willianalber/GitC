using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabalhoFinalApi.Models
{
    public class ContextDb : DbContext
    {
        public DbSet<Colaborador> colaboradors { get; set; }
        public DbSet<Cor> cores { get; set; }
        public DbSet<Locacao> locacaos { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Modelo> modelos { get; set; }
        public DbSet<PeriodoLocacao> periodoLocacaos { get; set; }
        public DbSet<Situacao> situacaos { get; set; }
        public DbSet<TermoLocacao> termosLocacoes { get; set; }
        public DbSet<TipoVeiculo> tipoVeiculos { get; set; }
        public DbSet<UsuarioLocador> usuarioLocadors { get; set; }
        public DbSet<Valor> valors { get; set; }
        public DbSet<Veiculo> veiculos { get; set; }

    }
}