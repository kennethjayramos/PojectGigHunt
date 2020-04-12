namespace GigHunt.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES ('1', 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('2', 'R&B')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('3', 'Rap')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('4', 'Pop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('5', 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('6', 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('7', 'Reggae')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('8', 'Ballad')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('9', 'Classical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('10', 'Alternative')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('11', 'Techno')");
            Sql("INSERT INTO Genres (Id, Name) VALUES ('12', 'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE ID IN (1,2,3,4,5,6,7,8,9,10,11,12)");
        }
    }
}
