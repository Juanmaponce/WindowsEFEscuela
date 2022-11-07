namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechaNaciemiento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.ProfesorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profesors");
            DropTable("dbo.Alumnoes");
        }
    }
}
