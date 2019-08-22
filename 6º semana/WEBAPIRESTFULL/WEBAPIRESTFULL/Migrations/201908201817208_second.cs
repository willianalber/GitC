namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Autores", "testeMigration", c => c.Boolean(nullable: false));
            AddColumn("dbo.Editoras", "testeMigration", c => c.Boolean(nullable: false));
            AddColumn("dbo.Generos", "testeMigration", c => c.Boolean(nullable: false));
            AddColumn("dbo.Usuarios", "testeMigration", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "testeMigration");
            DropColumn("dbo.Generos", "testeMigration");
            DropColumn("dbo.Editoras", "testeMigration");
            DropColumn("dbo.Autores", "testeMigration");
        }
    }
}
