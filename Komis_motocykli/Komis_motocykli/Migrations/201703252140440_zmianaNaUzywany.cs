namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zmianaNaUzywany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Motocykl", "Uzywany", c => c.Boolean(nullable: false));
            DropColumn("dbo.Motocykl", "Ukryty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Motocykl", "Ukryty", c => c.Boolean(nullable: false));
            DropColumn("dbo.Motocykl", "Uzywany");
        }
    }
}
