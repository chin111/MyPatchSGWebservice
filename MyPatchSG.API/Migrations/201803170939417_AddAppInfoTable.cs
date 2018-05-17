namespace MyPatchSG.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAppInfoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppInfoes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ClientOS = c.String(maxLength: 100),
                        Version = c.String(maxLength: 10),
                        AppStoreURL = c.String(maxLength: 500),
                        ForceUpdate = c.Boolean(nullable: false),
                        Remark = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AppInfoes");
        }
    }
}
