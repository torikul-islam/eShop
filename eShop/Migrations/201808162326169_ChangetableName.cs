namespace eShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangetableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Shops", newName: "Catagories");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Catagories", newName: "Shops");
        }
    }
}
