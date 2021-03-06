﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ytk_mvc.Entity;

namespace ytk_mvc.DAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base("dataConnection")
        {
            //Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImageFolder> ImageFolders { get; set; }
        public DbSet<ParticalPage> ParticalPages { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}