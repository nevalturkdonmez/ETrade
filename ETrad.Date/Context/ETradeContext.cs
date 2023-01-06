using System;
using ETrad.Date.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ETrade.Data.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace ETrade.Data.Context
{
 public class ETradeContext:IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("server=;initial Catalog=EtradeDatabase;integrated security=true;");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
    }
}
