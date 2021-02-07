namespace ProductStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingModifiedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logs", "ModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Logs", "ModifiedDate");
        }
    }
}
