﻿namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePricesale : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(precision: 18, scale: 2));
            CreateIndex("dbo.tb_ProductImage", "ProductId");
            AddForeignKey("dbo.tb_ProductImage", "ProductId", "dbo.tb_Product", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_ProductImage", "ProductId", "dbo.tb_Product");
            DropIndex("dbo.tb_ProductImage", new[] { "ProductId" });
            AlterColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
