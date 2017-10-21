namespace ClassDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemCategory", "ColorCode", c => c.String());
            AddColumn("dbo.ItemPriority", "ColorCode", c => c.String());
            AddColumn("dbo.itemStatus", "ColorCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.itemStatus", "ColorCode");
            DropColumn("dbo.ItemPriority", "ColorCode");
            DropColumn("dbo.ItemCategory", "ColorCode");
        }
    }
}
