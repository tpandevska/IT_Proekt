namespace IT_Proekt_173032.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novoVreme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Dt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Dt");
        }
    }
}
