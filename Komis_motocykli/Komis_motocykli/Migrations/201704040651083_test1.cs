namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PozycjaZamowienia", "motocykl_MotocyklId", "dbo.Motocykl");
            DropIndex("dbo.PozycjaZamowienia", new[] { "motocykl_MotocyklId" });
            RenameColumn(table: "dbo.PozycjaZamowienia", name: "motocykl_MotocyklId", newName: "MotocyklId");
            AlterColumn("dbo.PozycjaZamowienia", "MotocyklId", c => c.Int(nullable: false));
            CreateIndex("dbo.PozycjaZamowienia", "MotocyklId");
            AddForeignKey("dbo.PozycjaZamowienia", "MotocyklId", "dbo.Motocykl", "MotocyklId", cascadeDelete: true);
            DropColumn("dbo.PozycjaZamowienia", "KursId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PozycjaZamowienia", "KursId", c => c.Int(nullable: false));
            DropForeignKey("dbo.PozycjaZamowienia", "MotocyklId", "dbo.Motocykl");
            DropIndex("dbo.PozycjaZamowienia", new[] { "MotocyklId" });
            AlterColumn("dbo.PozycjaZamowienia", "MotocyklId", c => c.Int());
            RenameColumn(table: "dbo.PozycjaZamowienia", name: "MotocyklId", newName: "motocykl_MotocyklId");
            CreateIndex("dbo.PozycjaZamowienia", "motocykl_MotocyklId");
            AddForeignKey("dbo.PozycjaZamowienia", "motocykl_MotocyklId", "dbo.Motocykl", "MotocyklId");
        }
    }
}
