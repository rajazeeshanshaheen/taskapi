using Microsoft.EntityFrameworkCore;
using taskapi.Models;
namespace taskapi.Data
{
    public class DataContext : DbContext 
    {
        
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        
        public DbSet<Item> item {get;set;}
        public DbSet<review> review {get;set;}
    
    }
}