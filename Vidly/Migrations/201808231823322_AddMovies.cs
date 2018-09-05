namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(NAME,Genre,ReleaseDate,DateAdded,NumberInStocks) VALUES ('The Hangover','Comedy',CAST('June 2, 2009' AS DATETIME),GETDATE(), 5)");
            Sql("INSERT INTO Movies(NAME,Genre,ReleaseDate,DateAdded,NumberInStocks) VALUES ('Die Hard','Action',CAST('July 15, 1988' AS DATETIME),GETDATE(), 7)");
            Sql("INSERT INTO Movies(NAME,Genre,ReleaseDate,DateAdded,NumberInStocks) VALUES ('The Terminator','Action', CAST('October 26, 1984' AS DATETIME),GETDATE(), 3)");
            Sql("INSERT INTO Movies(NAME,Genre,ReleaseDate,DateAdded,NumberInStocks) VALUES ('Toy Story','Family',CAST('November 22, 1995' AS DATETIME),GETDATE(), 2)");
            Sql("INSERT INTO Movies(NAME,Genre,ReleaseDate,DateAdded,NumberInStocks) VALUES ('Titanic','Romance',CAST('December 19, 1997 ' AS DATETIME),GETDATE(), 3)");
        }

        public override void Down()
        {
        }
    }
}
