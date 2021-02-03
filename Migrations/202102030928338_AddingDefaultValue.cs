namespace ProductStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDefaultValue : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Sold", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Sold");
        }
    }
}
