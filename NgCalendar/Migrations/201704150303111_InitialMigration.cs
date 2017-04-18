namespace NgCalendar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100, unicode: false),
                        Description = c.String(maxLength: 200, unicode: false),
                        StartAt = c.DateTime(nullable: false),
                        EndAt = c.DateTime(),
                        IsFullDay = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
