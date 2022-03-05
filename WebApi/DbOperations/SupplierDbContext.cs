using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using WebApi.Models;

namespace WebApi.DbOperations
{
    public class SupplierDbContext : DbContext
    {


        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     // connect to mysql with connection string from app settings
        //     var connectionString = Configuration.GetConnectionString("WebApiDatabase");
        //     options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        // }

        public DbSet<Supplier> Suppliers { get; set; }
        public SupplierDbContext(DbContextOptions<SupplierDbContext> options) : base(options)     {}

    }
}