namespace Armonia.Ambulator.Model.Nomenclatoare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Display : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.NomCountries", name: "Name", newName: "nume_display");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.NomCountries", name: "nume_display", newName: "Name");
        }
    }
}
