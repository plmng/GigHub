namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Geners (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Geners (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Geners (Id, Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Geners (Id, Name) VALUES (4, 'Pop')");
            Sql("INSERT INTO Geners (Id, Name) VALUES (5, 'Country')");
            
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Geners WHERE Id IN (1,2,3,4,5)"); 
        }
    }
}
