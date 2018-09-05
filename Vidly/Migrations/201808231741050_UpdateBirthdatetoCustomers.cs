namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthdatetoCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set BirthDate = CAST('07/27/1990' AS DATETIME) WHERE ID = 2");
        }
        
        public override void Down()
        {
        }
    }
}
