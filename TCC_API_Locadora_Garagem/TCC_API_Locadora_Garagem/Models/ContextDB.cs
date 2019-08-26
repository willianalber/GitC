namespace TCC_API_Locadora_Garagem.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContextDB : DbContext
    {
        public ContextDB()
            : base("name=ContextDB")
        {
        }

        

        public DbSet<TipoVeiculo> veiculos { get; set; }
        public DbSet<TermoLocacao> termoLocacaos { get; set; }
        public DbSet<TabelaValor> tabelaValors { get; set; }
        public DbSet<PeriodoLocacao> periodoLocacaos { get; set; }
        public DbSet<Modelo> modelos { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Locador> Locadors { get; set; }
        public DbSet<Locacao> locacaos { get; set; }
        public DbSet<Cor> cors { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        //public virtual DbSet<Colaborador> Colaboradores { get; set; }


    }

}