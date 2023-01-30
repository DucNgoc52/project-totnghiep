namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeProductcategory1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Product", "ProductCategory_Id", "dbo.ProductCategories");
            DropIndex("dbo.tb_Product", new[] { "ProductCategory_Id" });
            RenameColumn(table: "dbo.tb_Product", name: "ProductCategory_Id", newName: "ProductCategoryId");
            AlterColumn("dbo.tb_Product", "ProductCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.tb_Product", "ProductCategoryId");
            AddForeignKey("dbo.tb_Product", "ProductCategoryId", "dbo.ProductCategories", "Id", cascadeDelete: true);
            DropColumn("dbo.tb_Product", "ProductCategotyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "ProductCategotyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tb_Product", "ProductCategoryId", "dbo.ProductCategories");
            DropIndex("dbo.tb_Product", new[] { "ProductCategoryId" });
            AlterColumn("dbo.tb_Product", "ProductCategoryId", c => c.Int());
            RenameColumn(table: "dbo.tb_Product", name: "ProductCategoryId", newName: "ProductCategory_Id");
            CreateIndex("dbo.tb_Product", "ProductCategory_Id");
            AddForeignKey("dbo.tb_Product", "ProductCategory_Id", "dbo.ProductCategories", "Id");
        }
    }
}
