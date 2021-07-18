using System.ComponentModel.DataAnnotations;

namespace Game.Models
{
  public class Drawing
  {
    public int DrawingId {get; set;}
    [Required]
    public string Date {get; set;}
    [Required]
    public List<int> Numbers {get; set;}
    [Required]
    public string Type {get; set;}
    public int Kicker {get; set;}

  }
}