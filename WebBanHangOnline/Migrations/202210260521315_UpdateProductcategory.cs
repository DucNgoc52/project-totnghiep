namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductcategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategories", "Alias", c => c.String());
            AlterColumn("dbo.ProductCategories", "Icon", c => c.String(maxLength: 250));
            AlterColumn("dbo.ProductCategories", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.ProductCategories", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.ProductCategories", "SeoKeywords", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductCategories", "SeoKeywords", c => c.String());
            AlterColumn("dbo.ProductCategories", "SeoDescription", c => c.String());
            AlterColumn("dbo.ProductCategories", "SeoTitle", c => c.String());
            AlterColumn("dbo.ProductCategories", "Icon", c => c.String());
            DropColumn("dbo.ProductCategories", "Alias");
        }
    }
}
