using Microsoft.EntityFrameworkCore;

namespace EconomicMappingAPI.Models
{
  public class EconomicMappingAPIContext : DbContext
  {
    public EconomicMappingAPIContext(DbContextOptions<EconomicMappingAPIContext> options) : base(options)
    {
      
    }
    public DbSet<State> States { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    builder.Entity<State>()
      .HasData(
        new State { StateId = 1, Name= "California", GDP= 2, MainExport= "coffee", MainImport= "avocodos" },
        new State { StateId = 2, Name= "Texas", GDP= 3, MainExport= "", MainImport= ""},
        new State {StateId = 3, Name= "Flordia", GDP=23, MainExport= "Spring Break", MainImport= "Freshmen"},
        new State {StateId = 4, Name= "Wisconsin", GDP=2, MainExport= "COWS", MainImport= "Nothing"},
        new State {StateId = 5, Name= "Oregon", GDP=23542, MainExport= "Wine", MainImport= "California"},
        new State {StateId = 6, Name= "Alabama", GDP=1, MainExport= "Moonshine", MainImport= "The bible"},
        new State {StateId = 7, Name= "Arkansas", GDP=4, MainExport= "Corn", MainImport= "Moonshine"},
        new State {StateId = 8, Name= "Alaska", GDP=0, MainExport= "Fish", MainImport= "IG Influencers"},
        new State {StateId = 9, Name= "Arizona", GDP=2, MainExport= "Sand", MainImport= "Heat"},
        new State {StateId = 10, Name= "Colorado", GDP=434, MainExport= "Skiing", MainImport= "Snow"},
        new State {StateId = 11, Name= "Connecticut", GDP=34, MainExport= "Penguins", MainImport= "CO2"},
        new State {StateId = 12, Name= "Delaware", GDP=3, MainExport= "Babies", MainImport= "Elephants"},
        new State {StateId = 13, Name= "Georgia", GDP=3, MainExport= "Racism", MainImport= "Nothing, Leeches"},
        new State {StateId = 14, Name= "Hawaii", GDP=5, MainExport= "Colonialism", MainImport= "Colonialism"},
        new State {StateId = 15, Name= "Idaho", GDP=678, MainExport= "rebels", MainImport= "Rebel flags"},
        new State {StateId = 16, Name= "Illinois", GDP=456, MainExport= "Al Capone", MainImport= "Chicago"},
        new State {StateId = 17, Name= "Indiana", GDP=45, MainExport= "Hoosiers", MainImport= "Corn"},
        new State {StateId = 18, Name= "Iowa", GDP=56, MainExport= "Hawkeyes", MainImport= "Corn"},
        new State {StateId = 19, Name= "Kansas", GDP=789, MainExport= "Dustbowl", MainImport= "Mahomes"},
        new State {StateId = 20, Name= "Kentucky", GDP=892, MainExport= "Moonshine", MainImport= "Pickles"},
        new State {StateId = 21, Name= "Louisiana", GDP=987, MainExport= "CrawDads", MainImport= "Oil"},
        new State {StateId = 22, Name= "Maine", GDP=345, MainExport= "Crabbies", MainImport= "Tourists"},
        new State {StateId = 23, Name= "Maryland", GDP=45, MainExport= "Donald Trump", MainImport= "Corruption"},
        new State {StateId = 24, Name= "Massachusetts", GDP=89, MainExport= "CAHS", MainImport= "Robbery"},
        new State {StateId = 25, Name= "Michigan", GDP=56, MainExport= "Eminem", MainImport= "tolerable weather"},
        new State {StateId = 26, Name= "Minnesota", GDP=74, MainExport= "OOPE", MainImport= "the Minnesota Nice"},
        new State {StateId = 27, Name= "Mississippi", GDP=4, MainExport= "Muddy Water", MainImport= "Cotton"},
        new State {StateId = 28, Name= "Missouri", GDP=67, MainExport= "Fiscal Disaster", MainImport= "Books"},
        new State {StateId = 29, Name= "Montana", GDP=5, MainExport= "Grizzlies", MainImport= "Glaciers"},
        new State {StateId = 30, Name= string, GDP=6, MainExport= string, MainImport= string},
        new State {StateId = 31, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 32, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 33, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 34, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 35, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 36, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 37, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 38, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 39, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 40, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 41, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 42, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 43, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 44, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 45, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 46, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 47, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 48, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 49, Name= string, GDP=num, MainExport= string, MainImport= string},
        new State {StateId = 50, Name= string, GDP=num, MainExport= string, MainImport= string}
      );
    }
  }
}    