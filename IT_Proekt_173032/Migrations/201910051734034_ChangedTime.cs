namespace IT_Proekt_173032.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Tip = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Info = c.String(),
                        ImgUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
        }
    }
}
