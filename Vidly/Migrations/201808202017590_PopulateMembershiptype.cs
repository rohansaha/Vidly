namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershiptype : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonts,DiscountRate) VALUES (1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonts,DiscountRate) VALUES (2,30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonts,DiscountRate) VALUES (3,90,3,15)");
            Sql("INSERT INTO MembershipTypes(Id,SignUpFee,DurationInMonts,DiscountRate) VALUES (4,120,12,20)");

        }
        
        public override void Down()
        {
        }
    }
}
