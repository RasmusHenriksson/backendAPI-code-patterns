using backendAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace backendAPI.Data
{
    
        // Här har jag utgått ifrån Single Responsibility Principle eftersom den bara har hand om min dataContext del till SQL
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions options) : base(options)
            {
            }

            public DbSet<ProductEntity> Products { get; set; }
        }
    }
