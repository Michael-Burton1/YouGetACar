using System.ComponentModel.DataAnnotations;

namespace RestServer.Models
{
  public class Drawing
  {
    public int DrawingId {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public string Date {get; set;}
    // [Required]
    // public List<int> Numbers {get; set;}
    [Required]
    public int Num1 {get; set;}
    [Required]
    public int Num2 {get; set;}
    [Required]
    public int Num3 {get; set;}
    [Required]
    public int Num4 {get; set;}
    [Required]
    public int Num5 {get; set;}
    public int Kicker {get; set;}

  }
}