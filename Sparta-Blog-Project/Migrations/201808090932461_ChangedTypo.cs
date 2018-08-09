namespace Sparta_Blog_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTypo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Author", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Blogs", "Authpr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Authpr", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Blogs", "Author");
        }
    }
}
