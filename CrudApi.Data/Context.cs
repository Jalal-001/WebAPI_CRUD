using CrudApi.Entity;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Data
{
    public class HotelContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0ETLVJF\SQLEXPRESS02;Database=CrudApi;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;") ;
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}