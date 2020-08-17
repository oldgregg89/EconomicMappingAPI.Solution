using Microsoft.EntityFrameworkCore;

namespace EconomicmappingAPI.Models
{
  public class EconomicmappingAPIContext : DbContext
  {
    public EconomicmappingAPIContext(DbContextOptions<EconomicmappingAPIContext> options) : base(options)
    {
      
    }
    public DbSet<> 
  }
}