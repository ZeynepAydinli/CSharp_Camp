using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework;

public class NorthwindContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-3PM8RA0\SQLEXPRESS; Database=northwind; Trusted_Connection=true; TrustServerCertificate=True");
    }
    public DbSet<Product> Products { get; set; } //Product class, veri tabanındaki Products tablosunu gördü
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}
