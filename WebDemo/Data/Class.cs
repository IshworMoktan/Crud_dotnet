using Microsoft.EntityFrameworkCore;
using WebDemo.Models;

namespace WebDemo.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }

    }
}
