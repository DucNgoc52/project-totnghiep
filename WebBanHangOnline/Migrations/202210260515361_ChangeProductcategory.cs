namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeProductcategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategories", "SeoTitle", c => c.String());
            DropColumn("dbo.ProductCategories", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductCategories", "Position", c => c.Int(nullable: false));
            DropColumn("dbo.ProductCategories", "SeoTitle");
        }
    }
}
