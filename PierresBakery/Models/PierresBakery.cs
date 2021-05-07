using System.Collections.Generic;

namespace PierresMenu.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    private static List<Bread> _instances = new List<Bread> {};
    public Bread(int amount)
    {
      Amount = amount;
    }
    public static List<Bread> GetAll()
    {
      return _instances;
    }
  }
}