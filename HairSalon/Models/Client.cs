namespace HairSalon.Models
{
  public class Client
  {
    public int Id {get; set;}
    public string Name {get; set;}
    public string Notes {get; set;}
    public int StylistId {get; set;}
    public virtual Stylist Stylist {get; set;}
  }
}