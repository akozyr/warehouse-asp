namespace warehouse_asp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catalogs_products_20170319_1249 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catalogs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(nullable: false),
                        catalogId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Catalogs", t => t.catalogId)
                .Index(t => t.catalogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "catalogId", "dbo.Catalogs");
            DropIndex("dbo.Products", new[] { "catalogId" });
            DropTable("dbo.Products");
            DropTable("dbo.Catalogs");
        }
    }
}
