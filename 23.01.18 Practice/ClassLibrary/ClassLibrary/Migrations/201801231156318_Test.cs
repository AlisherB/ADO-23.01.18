namespace ClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsersGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                        EnteredDate = c.DateTime(nullable: false),
                        IsActiveMember = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.UserInGroupHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        UserGroupsRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UsersGroups", t => t.UserGroupsRecordId, cascadeDelete: true)
                .Index(t => t.UserGroupsRecordId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsersGroups", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserInGroupHistories", "UserGroupsRecordId", "dbo.UsersGroups");
            DropForeignKey("dbo.UsersGroups", "GroupId", "dbo.Groups");
            DropIndex("dbo.UserInGroupHistories", new[] { "UserGroupsRecordId" });
            DropIndex("dbo.UsersGroups", new[] { "GroupId" });
            DropIndex("dbo.UsersGroups", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserInGroupHistories");
            DropTable("dbo.UsersGroups");
            DropTable("dbo.Groups");
        }
    }
}
