namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Zmianapolzamowien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zamowienie", "StanZamowienia", c => c.Int(nullable: false));
            DropColumn("dbo.Zamowienie", "StanTranzakcji");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zamowienie", "StanTranzakcji", c => c.Int(nullable: false));
            DropColumn("dbo.Zamowienie", "StanZamowienia");
        }
    }
}
