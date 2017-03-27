namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PozycjaZamowienia",
                c => new
                    {
                        PozycjaZamowieniaId = c.Int(nullable: false, identity: true),
                        ZamowienieID = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        motocykl_MotocyklId = c.Int(),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Motocykl", t => t.motocykl_MotocyklId)
                .ForeignKey("dbo.Zamowienie", t => t.ZamowienieID, cascadeDelete: true)
                .Index(t => t.ZamowienieID)
                .Index(t => t.motocykl_MotocyklId);
            
            AddColumn("dbo.Zamowienie", "WartoscZamowienia", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PozycjaZamowienia", "ZamowienieID", "dbo.Zamowienie");
            DropForeignKey("dbo.PozycjaZamowienia", "motocykl_MotocyklId", "dbo.Motocykl");
            DropIndex("dbo.PozycjaZamowienia", new[] { "motocykl_MotocyklId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "ZamowienieID" });
            DropColumn("dbo.Zamowienie", "WartoscZamowienia");
            DropTable("dbo.PozycjaZamowienia");
        }
    }
}
