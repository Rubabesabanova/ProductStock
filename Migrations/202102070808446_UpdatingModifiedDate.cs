namespace ProductStock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingModifiedDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logs", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logs", "ModifiedDate", c => c.DateTime(nullable: false));
        }
    }
}
