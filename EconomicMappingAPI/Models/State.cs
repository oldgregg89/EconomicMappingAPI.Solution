using System.ComponentModel.DataAnnotations;

namespace EconomicMappingAPI
{
  public class State
  {
    public int StateId { get; set; }
    public string Name { get; set; }
    public int GDP { get; set; }
    public string MainExport { get; set; }
    public string MainImport { get; set; }
    
  }
}