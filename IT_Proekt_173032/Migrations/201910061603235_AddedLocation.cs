namespace IT_Proekt_173032.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Location", c => c.String(nullable: false));
            AddColumn("dbo.Tickets", "numberTickets", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "numberTickets");
            DropColumn("dbo.Tickets", "Location");
        }
    }
}
