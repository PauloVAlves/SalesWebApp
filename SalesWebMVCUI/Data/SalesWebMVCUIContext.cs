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

        public DbSet<SalesWebMVCUI.Models.Department> Department { get; set; }
    }
}
