namespace WebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class locacaoDB : DbContext
    {
        public locacaoDB()
            : base("name=locacaoDB")
        {
        }

        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Carro> Carros { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Nota> Notas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Aluno>()
                .HasMany(e => e.Notas)
                .WithRequired(e => e.Aluno1)
                .HasForeignKey(e => e.aluno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Carro>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Carro>()
                .HasMany(e => e.Vendas)
                .WithRequired(e => e.Carro1)
                .HasForeignKey(e => e.Carro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Carros)
                .WithRequired(e => e.Marca1)
                .HasForeignKey(e => e.Marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Venda>()
                .Property(e => e.Valor)
                .HasPrecision(19, 4);
        }
    }
}
