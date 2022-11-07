namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aula",
                c => new
                    {
                        AulaId = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 8000, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.AulaId);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        MateriaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Programa = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.MateriaId);
            
            AddColumn("dbo.Profesor", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesor", "Titulo");
            DropTable("dbo.Materia");
            DropTable("dbo.Aula");
        }
    }
}
