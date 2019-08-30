namespace TrabalhoFinalApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0000001 : DbMigration
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
                        IdColaborador = c.Int(nullable: false),
                        IdTermoLocacao = c.Int(nullable: false),
                        ResideFora = c.Boolean(nullable: false),
                        OfereceCarona = c.Boolean(nullable: false),
                        IdSituacao = c.Int(nullable: false),
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
                        Codigo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        IDTipoVeiculo = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false),
                        IDMarca = c.Int(nullable: false),
                        IDTipoVeiculo = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        Colaborador = c.Int(nullable: false),
                        Marca = c.Int(nullable: false),
                        IdModelo = c.Int(nullable: false),
                        IdCor = c.Int(nullable: false),
                        Placa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veiculoes");
            DropTable("dbo.Valors");
            DropTable("dbo.UsuarioLocadors");
            DropTable("dbo.TipoVeiculoes");
            DropTable("dbo.TermoLocacaos");
            DropTable("dbo.Situacaos");
            DropTable("dbo.PeriodoLocacaos");
            DropTable("dbo.Modeloes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Cors");
            DropTable("dbo.Colaboradors");
        }
    }
}
