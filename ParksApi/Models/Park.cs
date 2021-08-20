using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Facilities { get; set; }
    public string Region { get; set; }

    public string Stats { get; set; }
  }
}
