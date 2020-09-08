using System;
using System.Collections.Generic;
using System.Text;
using dscSportSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dscSportSolution.Data.EF
{
    public class dscSportDbContext : DbContext
    {
        public dscSportDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
