namespace eShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAllowhtmlToPage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pages", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pages", "Title", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
