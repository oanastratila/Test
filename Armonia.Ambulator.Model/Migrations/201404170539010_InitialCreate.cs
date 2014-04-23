namespace Armonia.Ambulator.Model.Nomenclatoare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NomCities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CityTypeId = c.Int(nullable: false),
                        DistricdId = c.Int(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                        District_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCityTypes", t => t.CityTypeId, cascadeDelete: true)
                .ForeignKey("dbo.NomDistricts", t => t.District_id)
                .Index(t => t.CityTypeId)
                .Index(t => t.District_id);
            
            CreateTable(
                "dbo.NomCityTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.NomDistricts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CountriesId = c.Int(nullable: false),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCountries", t => t.CountriesId, cascadeDelete: true)
                .Index(t => t.CountriesId);
            
            CreateTable(
                "dbo.NomCountries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.NomCnasAgreements",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCountries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NomDistricts", "CountriesId", "dbo.NomCountries");
            DropForeignKey("dbo.NomCnasAgreements", "CountryId", "dbo.NomCountries");
            DropForeignKey("dbo.NomCities", "District_id", "dbo.NomDistricts");
            DropForeignKey("dbo.NomCities", "CityTypeId", "dbo.NomCityTypes");
            DropIndex("dbo.NomCnasAgreements", new[] { "CountryId" });
            DropIndex("dbo.NomDistricts", new[] { "CountriesId" });
            DropIndex("dbo.NomCities", new[] { "District_id" });
            DropIndex("dbo.NomCities", new[] { "CityTypeId" });
            DropTable("dbo.NomCnasAgreements");
            DropTable("dbo.NomCountries");
            DropTable("dbo.NomDistricts");
            DropTable("dbo.NomCityTypes");
            DropTable("dbo.NomCities");
        }
    }
}
