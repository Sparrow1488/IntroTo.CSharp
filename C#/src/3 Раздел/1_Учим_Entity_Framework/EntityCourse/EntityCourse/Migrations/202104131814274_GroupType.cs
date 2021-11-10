namespace EntityCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroupType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Int(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "GroupId", "dbo.Groups");
            DropIndex("dbo.Songs", new[] { "GroupId" });
            DropTable("dbo.Songs");
            DropTable("dbo.Groups");
        }
    }
}
