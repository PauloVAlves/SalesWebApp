using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVCUI.Models;

namespace SalesWebMVCUI.Data
{
    public class SalesWebMVCUIContext : DbContext
    {
        public SalesWebMVCUIContext (DbContextOptions<SalesWebMVCUIContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
