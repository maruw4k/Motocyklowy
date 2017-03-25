namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usunieciePolaTest : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Motocykl", "Test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Motocykl", "Test", c => c.String());
        }
    }
}
