namespace TrabalhoFinalApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _00002 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PeriodoLocacaos", "IdTipoVeiculo", "dbo.TipoVeiculoes");
            DropIndex("dbo.PeriodoLocacaos", new[] { "IdTipoVeiculo" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.PeriodoLocacaos", "IdTipoVeiculo");
            AddForeignKey("dbo.PeriodoLocacaos", "IdTipoVeiculo", "dbo.TipoVeiculoes", "Id", cascadeDelete: true);
        }
    }
}
