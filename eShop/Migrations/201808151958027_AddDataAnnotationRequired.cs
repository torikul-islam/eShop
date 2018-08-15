namespace eShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pages", "Title", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Pages", "Slug", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "Slug", c => c.String(maxLength: 30));
            AlterColumn("dbo.Pages", "Title", c => c.String(maxLength: 30));
        }
    }
}
