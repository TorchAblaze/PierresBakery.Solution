using System.Collections.Generic;

namespace PierresMenu.Models
{
  public class Pastry
  {
    public int Amount { get; set; }
    private static List<Pastry> _instances = new List<Pastry> {};
    public Pastry(int amount)
    {
      Amount = amount;
      _instances.Add(this);
    }
    public static List<Pastry> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int OrderTotal()
    {
      int remainder = Amount % 3;
      return (Amount / 3 * 5) + (remainder * 2);
    }
  }
}