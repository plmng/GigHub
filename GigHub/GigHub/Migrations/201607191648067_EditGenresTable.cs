namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditGenresTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Geners", newName: "Genres");
            RenameColumn(table: "dbo.Gigs", name: "Gener_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Gigs", name: "IX_Gener_Id", newName: "IX_Genre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Gigs", name: "IX_Genre_Id", newName: "IX_Gener_Id");
            RenameColumn(table: "dbo.Gigs", name: "Genre_Id", newName: "Gener_Id");
            RenameTable(name: "dbo.Genres", newName: "Geners");
        }
    }
}
