namespace TrabalhoFinalApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _00001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colaboradors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Pcd = c.Boolean(nullable: false),
                        TrabalhaNoturno = c.Boolean(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdVeiculo = c.Int(nullable: false),
                        IdPeriodoLocacao = c.Int(nullable: false),
                        IdUsuarioLocacao = c.Int(nullable: false),
                        IdTermoLocacao = c.Int(nullable: false),
                        IdSituacao = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PeriodoLocacaos", t => t.IdPeriodoLocacao, cascadeDelete: true)
                .ForeignKey("dbo.Situacaos", t => t.IdSituacao, cascadeDelete: true)
                .ForeignKey("dbo.TermoLocacaos", t => t.IdTermoLocacao, cascadeDelete: true)
                .ForeignKey("dbo.UsuarioLocadors", t => t.IdUsuarioLocacao, cascadeDelete: true)
                .ForeignKey("dbo.Veiculoes", t => t.IdVeiculo, cascadeDelete: true)
                .Index(t => t.IdVeiculo)
                .Index(t => t.IdPeriodoLocacao)
                .Index(t => t.IdUsuarioLocacao)
                .Index(t => t.IdTermoLocacao)
                .Index(t => t.IdSituacao);
            
            CreateTable(
                "dbo.PeriodoLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdTipoVeiculo = c.Int(nullable: false),
                        DataInicio = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculoes", t => t.IdTipoVeiculo, cascadeDelete: true)
                .Index(t => t.IdTipoVeiculo);
            
            CreateTable(
                "dbo.TipoVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Situacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TermoLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsuarioLocadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdColaborador = c.Int(nullable: false),
                        ResideFora = c.Boolean(nullable: false),
                        OfereceCarona = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Colaboradors", t => t.IdColaborador, cascadeDelete: true)
                .Index(t => t.IdColaborador);
            
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdModelo = c.Int(nullable: false),
                        IdCor = c.Int(nullable: false),
                        Placa = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cors", t => t.IdCor, cascadeDelete: true)
                .ForeignKey("dbo.Modeloes", t => t.IdModelo, cascadeDelete: true)
                .Index(t => t.IdModelo)
                .Index(t => t.IdCor);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        IDMarca = c.Int(nullable: false),
                        IDTipoVeiculo = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        IDTipoVeiculo = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Valors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPeriodoLocacao = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PeriodoLocacaos", t => t.IdPeriodoLocacao, cascadeDelete: true)
                .Index(t => t.IdPeriodoLocacao);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Valors", "IdPeriodoLocacao", "dbo.PeriodoLocacaos");
            DropForeignKey("dbo.Locacaos", "IdVeiculo", "dbo.Veiculoes");
            DropForeignKey("dbo.Veiculoes", "IdModelo", "dbo.Modeloes");
            DropForeignKey("dbo.Veiculoes", "IdCor", "dbo.Cors");
            DropForeignKey("dbo.Locacaos", "IdUsuarioLocacao", "dbo.UsuarioLocadors");
            DropForeignKey("dbo.UsuarioLocadors", "IdColaborador", "dbo.Colaboradors");
            DropForeignKey("dbo.Locacaos", "IdTermoLocacao", "dbo.TermoLocacaos");
            DropForeignKey("dbo.Locacaos", "IdSituacao", "dbo.Situacaos");
            DropForeignKey("dbo.Locacaos", "IdPeriodoLocacao", "dbo.PeriodoLocacaos");
            DropForeignKey("dbo.PeriodoLocacaos", "IdTipoVeiculo", "dbo.TipoVeiculoes");
            DropIndex("dbo.Valors", new[] { "IdPeriodoLocacao" });
            DropIndex("dbo.Veiculoes", new[] { "IdCor" });
            DropIndex("dbo.Veiculoes", new[] { "IdModelo" });
            DropIndex("dbo.UsuarioLocadors", new[] { "IdColaborador" });
            DropIndex("dbo.PeriodoLocacaos", new[] { "IdTipoVeiculo" });
            DropIndex("dbo.Locacaos", new[] { "IdSituacao" });
            DropIndex("dbo.Locacaos", new[] { "IdTermoLocacao" });
            DropIndex("dbo.Locacaos", new[] { "IdUsuarioLocacao" });
            DropIndex("dbo.Locacaos", new[] { "IdPeriodoLocacao" });
            DropIndex("dbo.Locacaos", new[] { "IdVeiculo" });
            DropTable("dbo.Valors");
            DropTable("dbo.Marcas");
            DropTable("dbo.Modeloes");
            DropTable("dbo.Veiculoes");
            DropTable("dbo.UsuarioLocadors");
            DropTable("dbo.TermoLocacaos");
            DropTable("dbo.Situacaos");
            DropTable("dbo.TipoVeiculoes");
            DropTable("dbo.PeriodoLocacaos");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Cors");
            DropTable("dbo.Colaboradors");
        }
    }
}
