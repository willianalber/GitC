namespace TrabalhoFinalApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _000001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculoes", "Tipo", c => c.Int(nullable: false));
            AddColumn("dbo.Veiculoes", "Colaborador", c => c.Int(nullable: false));
            AddColumn("dbo.Veiculoes", "Marca", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veiculoes", "Marca");
            DropColumn("dbo.Veiculoes", "Colaborador");
            DropColumn("dbo.Veiculoes", "Tipo");
        }
    }
}
