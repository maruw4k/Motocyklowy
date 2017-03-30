namespace Komis_motocykli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Zamowienia : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Zamowienie", name: "ApplicationUser_Id", newName: "userId");
            RenameIndex(table: "dbo.Zamowienie", name: "IX_ApplicationUser_Id", newName: "IX_userId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Zamowienie", name: "IX_userId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.Zamowienie", name: "userId", newName: "ApplicationUser_Id");
        }
    }
}
