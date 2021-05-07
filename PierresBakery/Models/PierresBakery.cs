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
      _instances.Add(this);
    }
    public static List<Bread> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int OrderTotal()
    {
      return Amount * 5;
    }
  }
}