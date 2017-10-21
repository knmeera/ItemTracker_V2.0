namespace ClassDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cati : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemType", "ColorCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemType", "ColorCode");
        }
    }
}
