namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoria",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(nullable: false),
                        OpisKategorii = c.String(nullable: false, maxLength: 200),
                        NazwaPlikuIkony = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Motocykl",
                c => new
                    {
                        MotocyklId = c.Int(nullable: false, identity: true),
                        KategoriaID = c.Int(nullable: false),
                        NazwaMotoru = c.String(nullable: false, maxLength: 50),
                        Pojemnosc = c.Int(nullable: false),
                        RokProdukcji = c.Int(nullable: false),
                        NazwaPlikuObrazka = c.String(),
                        OpisMotoru = c.String(),
                        CenaMotoru = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Uzywany = c.Boolean(nullable: false),
                        OpisSkrocony = c.String(),
                    })
                .PrimaryKey(t => t.MotocyklId)
                .ForeignKey("dbo.Kategoria", t => t.KategoriaID, cascadeDelete: true)
                .Index(t => t.KategoriaID);
            
            CreateTable(
                "dbo.Zamowienie",
                c => new
                    {
                        ZamowienieID = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false, maxLength: 50),
                        Nazwisko = c.String(nullable: false, maxLength: 50),
                        Telefon = c.String(),
                        Email = c.String(nullable: false, maxLength: 50),
                        DataDodania = c.DateTime(nullable: false),
                        StanTranzakcji = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZamowienieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Motocykl", "KategoriaID", "dbo.Kategoria");
            DropIndex("dbo.Motocykl", new[] { "KategoriaID" });
            DropTable("dbo.Zamowienie");
            DropTable("dbo.Motocykl");
            DropTable("dbo.Kategoria");
        }
    }
}
