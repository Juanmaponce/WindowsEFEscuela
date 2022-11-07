namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
            RenameTable(name: "dbo.Profesors", newName: "Profesor");
            AlterColumn("dbo.Alumno", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumno", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumno", "FechaNaciemiento", c => c.DateTime());
            AlterColumn("dbo.Profesor", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesor", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profesor", "Apellido", c => c.String());
            AlterColumn("dbo.Profesor", "Nombre", c => c.String());
            AlterColumn("dbo.Alumno", "FechaNaciemiento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Alumno", "Apellido", c => c.String());
            AlterColumn("dbo.Alumno", "Nombre", c => c.String());
            RenameTable(name: "dbo.Profesor", newName: "Profesors");
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
