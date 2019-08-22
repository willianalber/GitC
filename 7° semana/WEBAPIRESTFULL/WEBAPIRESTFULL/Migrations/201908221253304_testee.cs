namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testee : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Livros", "Editora", "dbo.Editoras");
            DropForeignKey("dbo.Livros", "Genero", "dbo.Generos");
            DropForeignKey("dbo.Livros", "UsuAlt", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "UsuInc", "dbo.Usuarios");
            DropIndex("dbo.Livros", new[] { "Genero" });
            DropIndex("dbo.Livros", new[] { "Editora" });
            DropIndex("dbo.Livros", new[] { "UsuInc" });
            DropIndex("dbo.Livros", new[] { "UsuAlt" });
            AddColumn("dbo.Livros", "Usuarios_Id", c => c.Int());
            AddColumn("dbo.Livros", "Usuarios_Id1", c => c.Int());
            AddColumn("dbo.Livros", "Editoras_Id", c => c.Int());
            AddColumn("dbo.Livros", "Generos_Id", c => c.Int());
            AlterColumn("dbo.Autores", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Autores", "UsuInc", c => c.Int());
            AlterColumn("dbo.Autores", "UsuAlt", c => c.Int());
            AlterColumn("dbo.Autores", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Autores", "DatAlt", c => c.DateTime());
            AlterColumn("dbo.Livros", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Livros", "UsuInc", c => c.Int());
            AlterColumn("dbo.Livros", "UsuAlt", c => c.Int());
            AlterColumn("dbo.Livros", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Livros", "DatAlt", c => c.DateTime());
            AlterColumn("dbo.Editoras", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Editoras", "UsuInc", c => c.Int());
            AlterColumn("dbo.Editoras", "UsuAlt", c => c.Int());
            AlterColumn("dbo.Editoras", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Editoras", "DatAlt", c => c.DateTime());
            AlterColumn("dbo.Generos", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Generos", "UsuInc", c => c.Int());
            AlterColumn("dbo.Generos", "UsuAlt", c => c.Int());
            AlterColumn("dbo.Generos", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Generos", "DatAlt", c => c.DateTime());
            AlterColumn("dbo.Usuarios", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Usuarios", "UsuInc", c => c.Int());
            AlterColumn("dbo.Usuarios", "UsuAlt", c => c.Int());
            AlterColumn("dbo.Usuarios", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Usuarios", "DatAlt", c => c.DateTime());
            CreateIndex("dbo.Livros", "Usuarios_Id");
            CreateIndex("dbo.Livros", "Usuarios_Id1");
            CreateIndex("dbo.Livros", "Editoras_Id");
            CreateIndex("dbo.Livros", "Generos_Id");
            AddForeignKey("dbo.Livros", "Editoras_Id", "dbo.Editoras", "Id");
            AddForeignKey("dbo.Livros", "Generos_Id", "dbo.Generos", "Id");
            AddForeignKey("dbo.Livros", "Usuarios_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Livros", "Usuarios_Id1", "dbo.Usuarios", "Id");
            DropColumn("dbo.Autores", "testeMigration");
            DropColumn("dbo.Editoras", "testeMigration");
            DropColumn("dbo.Generos", "testeMigration");
            DropColumn("dbo.Usuarios", "testeMigration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "testeMigration", c => c.Boolean(nullable: false));
            AddColumn("dbo.Generos", "testeMigration", c => c.Boolean(nullable: false));
            AddColumn("dbo.Editoras", "testeMigration", c => c.Boolean(nullable: false));
            AddColumn("dbo.Autores", "testeMigration", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Livros", "Usuarios_Id1", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Generos_Id", "dbo.Generos");
            DropForeignKey("dbo.Livros", "Editoras_Id", "dbo.Editoras");
            DropIndex("dbo.Livros", new[] { "Generos_Id" });
            DropIndex("dbo.Livros", new[] { "Editoras_Id" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id1" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id" });
            AlterColumn("dbo.Usuarios", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Usuarios", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Usuarios", "UsuAlt", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "UsuInc", c => c.Int(nullable: false));
            AlterColumn("dbo.Usuarios", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Generos", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Generos", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Generos", "UsuAlt", c => c.Int(nullable: false));
            AlterColumn("dbo.Generos", "UsuInc", c => c.Int(nullable: false));
            AlterColumn("dbo.Generos", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Editoras", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Editoras", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Editoras", "UsuAlt", c => c.Int(nullable: false));
            AlterColumn("dbo.Editoras", "UsuInc", c => c.Int(nullable: false));
            AlterColumn("dbo.Editoras", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Livros", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Livros", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Livros", "UsuAlt", c => c.Int(nullable: false));
            AlterColumn("dbo.Livros", "UsuInc", c => c.Int(nullable: false));
            AlterColumn("dbo.Livros", "Ativo", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Autores", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Autores", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Autores", "UsuAlt", c => c.Int(nullable: false));
            AlterColumn("dbo.Autores", "UsuInc", c => c.Int(nullable: false));
            AlterColumn("dbo.Autores", "Ativo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Livros", "Generos_Id");
            DropColumn("dbo.Livros", "Editoras_Id");
            DropColumn("dbo.Livros", "Usuarios_Id1");
            DropColumn("dbo.Livros", "Usuarios_Id");
            CreateIndex("dbo.Livros", "UsuAlt");
            CreateIndex("dbo.Livros", "UsuInc");
            CreateIndex("dbo.Livros", "Editora");
            CreateIndex("dbo.Livros", "Genero");
            AddForeignKey("dbo.Livros", "UsuInc", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Livros", "UsuAlt", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Livros", "Genero", "dbo.Generos", "Id");
            AddForeignKey("dbo.Livros", "Editora", "dbo.Editoras", "Id");
        }
    }
}
