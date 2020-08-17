using Microsoft.EntityFrameworkCore;

namespace EconomicMappingAPI.Models
{
  public class EconomicmappingAPIContext : DbContext
  {
    public EconomicMappingAPIContext(DbContextOptions<EconomicMappingAPIContext> options) : base(options)
    {
      
    }
    public DbSet<State> States { get; set; }
  }
}