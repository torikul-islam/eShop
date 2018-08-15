namespace eShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pages", "Title", c => c.String(maxLength: 30));
            AlterColumn("dbo.Pages", "Slug", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "Slug", c => c.String());
            AlterColumn("dbo.Pages", "Title", c => c.String());
        }
    }
}
