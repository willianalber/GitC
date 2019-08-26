namespace TCC_API_Locadora_Garagem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Build0001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colaboradors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 500),
                        Email = c.String(nullable: false, maxLength: 100),
                        TemPcd = c.Boolean(nullable: false),
                        TrabalhaNoturno = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Placa = c.String(),
                        AceiteTermo = c.Boolean(nullable: false),
                        Situacao = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cors", t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Id)
                .ForeignKey("dbo.Modeloes", t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 500),
                        TipoVeiculoFK = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculoFK, cascadeDelete: true)
                .Index(t => t.TipoVeiculoFK);
            
            CreateTable(
                "dbo.TipoVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarcaModeloFK = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 500),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaModeloFK, cascadeDelete: true)
                .Index(t => t.MarcaModeloFK);
            
            CreateTable(
                "dbo.Locadors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        OfereceCarona = c.Boolean(nullable: false),
                        ResideFora = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colaboradors", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PeriodoLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoVeiculoPeriodoLocacaoFK = c.Int(nullable: false),
                        Turno = c.String(),
                        DataInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        QtdVagas = c.Int(nullable: false),
                        TabelaValor = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculoPeriodoLocacaoFK, cascadeDelete: true)
                .Index(t => t.TipoVeiculoPeriodoLocacaoFK);
            
            CreateTable(
                "dbo.TabelaValors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 500),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TermoLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PeriodoLocacaos", "TipoVeiculoPeriodoLocacaoFK", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locadors", "Id", "dbo.Colaboradors");
            DropForeignKey("dbo.Locacaos", "Id", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "Id", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "MarcaModeloFK", "dbo.Marcas");
            DropForeignKey("dbo.Locacaos", "Id", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipoVeiculoFK", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "Id", "dbo.Cors");
            DropIndex("dbo.PeriodoLocacaos", new[] { "TipoVeiculoPeriodoLocacaoFK" });
            DropIndex("dbo.Locadors", new[] { "Id" });
            DropIndex("dbo.Modeloes", new[] { "MarcaModeloFK" });
            DropIndex("dbo.Marcas", new[] { "TipoVeiculoFK" });
            DropIndex("dbo.Locacaos", new[] { "Id" });
            DropTable("dbo.TermoLocacaos");
            DropTable("dbo.TabelaValors");
            DropTable("dbo.PeriodoLocacaos");
            DropTable("dbo.Locadors");
            DropTable("dbo.Modeloes");
            DropTable("dbo.TipoVeiculoes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Cors");
            DropTable("dbo.Colaboradors");
        }
    }
}
