namespace IT_Proekt_173032.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novaMigracija : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tickets", "Dt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Dt", c => c.DateTime());
        }
    }
}
