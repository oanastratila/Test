namespace Armonia.Ambulator.Model.Nomenclatoare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDrug : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NomDrugs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PresentationMode = c.String(),
                        IsNarcotic = c.Short(nullable: false),
                        IsFractional = c.Boolean(nullable: false),
                        IsSpecial = c.Boolean(nullable: false),
                        IsBrand = c.Boolean(nullable: false),
                        HasBioEchiv = c.Boolean(nullable: false),
                        QtyPerPackage = c.Int(nullable: false),
                        PricePerPackage = c.Single(nullable: false),
                        WholeSalePricePerPackage = c.Single(nullable: false),
                        PrescriptionMode = c.String(),
                        ConcentrationId = c.Int(nullable: false),
                        PharmaceuticalFormId = c.Int(nullable: false),
                        Company = c.String(),
                        Country = c.String(),
                        Atc = c.String(),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        Code = c.String(),
                        Name = c.String(),
                        ActiveSubstance_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomActiveSubstances", t => t.ActiveSubstance_id)
                .ForeignKey("dbo.NomConcentrations", t => t.ConcentrationId, cascadeDelete: true)
                .ForeignKey("dbo.NomPharmaceuticalForms", t => t.PharmaceuticalFormId, cascadeDelete: true)
                .Index(t => t.ConcentrationId)
                .Index(t => t.PharmaceuticalFormId)
                .Index(t => t.ActiveSubstance_id);
            
            CreateTable(
                "dbo.NomActiveSubstances",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        Atc_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomATCs", t => t.Atc_id)
                .Index(t => t.Atc_id);
            
            CreateTable(
                "dbo.NomATCs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DescriptionId = c.Int(nullable: false),
                        ParentATC = c.String(),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        Code = c.String(),
                        Descripton = c.String(),
                        NomCopaymentListDrug_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCopaymentListDrugs", t => t.NomCopaymentListDrug_id)
                .Index(t => t.NomCopaymentListDrug_id);
            
            CreateTable(
                "dbo.NomCopaymentListDrugs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        DiseaseCategoryId = c.Int(nullable: false),
                        MaxPrice = c.Single(nullable: false),
                        MaxPriceUt = c.Single(nullable: false),
                        CopaymentValue = c.Single(nullable: false),
                        CopaymentValue90 = c.Single(nullable: false),
                        WholeSalePrice = c.Single(nullable: false),
                        ReferencePrice = c.Single(nullable: false),
                        SpecialLaw = c.Boolean(nullable: false),
                        NeedApproval = c.String(),
                        OverValue = c.String(),
                        NeedSpecialty = c.String(),
                        ClassIfInsulin = c.String(),
                        HgDci = c.String(),
                        CopaymentListType_id = c.Int(),
                        NomActiveSubstance_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCopaymentListTypes", t => t.CopaymentListType_id)
                .ForeignKey("dbo.NomActiveSubstances", t => t.NomActiveSubstance_id)
                .Index(t => t.CopaymentListType_id)
                .Index(t => t.NomActiveSubstance_id);
            
            CreateTable(
                "dbo.NomCopaymentListTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CopaymentListTypesId = c.Int(nullable: false),
                        Percent = c.Int(nullable: false),
                        MaxValue = c.Int(nullable: false),
                        DrugMaxNo = c.Int(nullable: false),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        Code = c.String(),
                        Descripton = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCopaymentListTypePersStates", t => t.CopaymentListTypesId, cascadeDelete: true)
                .Index(t => t.CopaymentListTypesId);
            
            CreateTable(
                "dbo.NomCopaymentListTypePersStates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PersonState = c.String(),
                        Percent = c.Int(nullable: false),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.NomDiseaseCategories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsChronicDisease = c.Boolean(nullable: false),
                        IsAuctioned = c.Boolean(nullable: false),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        Code = c.String(),
                        Descripton = c.String(),
                        DiseaseCode_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCopaymentListDrugs", t => t.DiseaseCode_id)
                .Index(t => t.DiseaseCode_id);
            
            CreateTable(
                "dbo.NomNHPs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        hasAmbulatoryBudget = c.Boolean(nullable: false),
                        hasHospitalBudget = c.Boolean(nullable: false),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        Code = c.String(),
                        Descripton = c.String(),
                        CopaymentDrug_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.NomCopaymentListDrugs", t => t.CopaymentDrug_id)
                .Index(t => t.CopaymentDrug_id);
            
            CreateTable(
                "dbo.NomConcentrations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.NomPharmaceuticalForms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ValidFrom = c.DateTime(nullable: false),
                        ValidTo = c.DateTime(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.NomCopaymentListDrugNomDrugs",
                c => new
                    {
                        NomCopaymentListDrug_id = c.Int(nullable: false),
                        NomDrug_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NomCopaymentListDrug_id, t.NomDrug_id })
                .ForeignKey("dbo.NomCopaymentListDrugs", t => t.NomCopaymentListDrug_id, cascadeDelete: true)
                .ForeignKey("dbo.NomDrugs", t => t.NomDrug_id, cascadeDelete: true)
                .Index(t => t.NomCopaymentListDrug_id)
                .Index(t => t.NomDrug_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NomDrugs", "PharmaceuticalFormId", "dbo.NomPharmaceuticalForms");
            DropForeignKey("dbo.NomDrugs", "ConcentrationId", "dbo.NomConcentrations");
            DropForeignKey("dbo.NomCopaymentListDrugs", "NomActiveSubstance_id", "dbo.NomActiveSubstances");
            DropForeignKey("dbo.NomNHPs", "CopaymentDrug_id", "dbo.NomCopaymentListDrugs");
            DropForeignKey("dbo.NomATCs", "NomCopaymentListDrug_id", "dbo.NomCopaymentListDrugs");
            DropForeignKey("dbo.NomCopaymentListDrugNomDrugs", "NomDrug_id", "dbo.NomDrugs");
            DropForeignKey("dbo.NomCopaymentListDrugNomDrugs", "NomCopaymentListDrug_id", "dbo.NomCopaymentListDrugs");
            DropForeignKey("dbo.NomDiseaseCategories", "DiseaseCode_id", "dbo.NomCopaymentListDrugs");
            DropForeignKey("dbo.NomCopaymentListTypes", "CopaymentListTypesId", "dbo.NomCopaymentListTypePersStates");
            DropForeignKey("dbo.NomCopaymentListDrugs", "CopaymentListType_id", "dbo.NomCopaymentListTypes");
            DropForeignKey("dbo.NomDrugs", "ActiveSubstance_id", "dbo.NomActiveSubstances");
            DropForeignKey("dbo.NomActiveSubstances", "Atc_id", "dbo.NomATCs");
            DropIndex("dbo.NomCopaymentListDrugNomDrugs", new[] { "NomDrug_id" });
            DropIndex("dbo.NomCopaymentListDrugNomDrugs", new[] { "NomCopaymentListDrug_id" });
            DropIndex("dbo.NomNHPs", new[] { "CopaymentDrug_id" });
            DropIndex("dbo.NomDiseaseCategories", new[] { "DiseaseCode_id" });
            DropIndex("dbo.NomCopaymentListTypes", new[] { "CopaymentListTypesId" });
            DropIndex("dbo.NomCopaymentListDrugs", new[] { "NomActiveSubstance_id" });
            DropIndex("dbo.NomCopaymentListDrugs", new[] { "CopaymentListType_id" });
            DropIndex("dbo.NomATCs", new[] { "NomCopaymentListDrug_id" });
            DropIndex("dbo.NomActiveSubstances", new[] { "Atc_id" });
            DropIndex("dbo.NomDrugs", new[] { "ActiveSubstance_id" });
            DropIndex("dbo.NomDrugs", new[] { "PharmaceuticalFormId" });
            DropIndex("dbo.NomDrugs", new[] { "ConcentrationId" });
            DropTable("dbo.NomCopaymentListDrugNomDrugs");
            DropTable("dbo.NomPharmaceuticalForms");
            DropTable("dbo.NomConcentrations");
            DropTable("dbo.NomNHPs");
            DropTable("dbo.NomDiseaseCategories");
            DropTable("dbo.NomCopaymentListTypePersStates");
            DropTable("dbo.NomCopaymentListTypes");
            DropTable("dbo.NomCopaymentListDrugs");
            DropTable("dbo.NomATCs");
            DropTable("dbo.NomActiveSubstances");
            DropTable("dbo.NomDrugs");
        }
    }
}
