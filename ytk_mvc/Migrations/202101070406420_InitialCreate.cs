﻿namespace ytk_mvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Description = c.String(),
                        IsVisible = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        DiscontRate = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                        IsVisible = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        ImageFolderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ImageFolders", t => t.ImageFolderId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ImageFolderId);
            
            CreateTable(
                "dbo.ImageFolders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageName = c.String(),
                        Description = c.String(),
                        ImageFolderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ImageFolders", t => t.ImageFolderId, cascadeDelete: true)
                .Index(t => t.ImageFolderId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        IsVisible = c.Boolean(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        ImageFolderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ImageFolders", t => t.ImageFolderId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ImageFolderId);
            
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "ImageFolderId", "dbo.ImageFolders");
            DropForeignKey("dbo.Projects", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "ImageFolderId", "dbo.ImageFolders");
            DropForeignKey("dbo.Images", "ImageFolderId", "dbo.ImageFolders");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Projects", new[] { "ImageFolderId" });
            DropIndex("dbo.Projects", new[] { "CategoryId" });
            DropIndex("dbo.Images", new[] { "ImageFolderId" });
            DropIndex("dbo.Products", new[] { "ImageFolderId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.Users");
            DropTable("dbo.ContactMessages");
            DropTable("dbo.ContactInfoes");
            DropTable("dbo.Projects");
            DropTable("dbo.Images");
            DropTable("dbo.ImageFolders");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
