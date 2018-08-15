namespace eShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBoolToPage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pages", "HasSidebar", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "HasSidebar", c => c.Int(nullable: false));
        }
    }
}
