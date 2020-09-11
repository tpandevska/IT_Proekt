namespace IT_Proekt_173032.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Time");
        }
    }
}
