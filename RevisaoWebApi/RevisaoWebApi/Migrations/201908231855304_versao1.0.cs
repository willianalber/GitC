namespace RevisaoWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versao10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "senha", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "senha", c => c.String(maxLength: 16));
        }
    }
}
