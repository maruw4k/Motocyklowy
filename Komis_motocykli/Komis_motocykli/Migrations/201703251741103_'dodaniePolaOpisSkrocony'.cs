namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniePolaOpisSkrocony : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Motocykl", "OpisSkrocony", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Motocykl", "OpisSkrocony");
        }
    }
}
