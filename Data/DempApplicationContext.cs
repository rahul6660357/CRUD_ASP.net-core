using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DempApplication.Model;

namespace DempApplication.Data
{
    public class DempApplicationContext : DbContext
    {
        public DempApplicationContext (DbContextOptions<DempApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<DempApplication.Model.Movie> Movie { get; set; }
    }
}
