namespace AuctionSystem.DAL
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bazaDanych2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Auctions", "AuctionOwnerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auctions", "AuctionOwnerID", c => c.Int(nullable: false));
        }
    }
}
