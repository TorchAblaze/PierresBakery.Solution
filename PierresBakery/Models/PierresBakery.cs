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
      if (Amount > 1)
      {
        return (Amount * 5) - (Amount / 3 * 5);
      }
      return Amount * 5;
    }
  }
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
      // WIP
      // return ((Amount/3 * 5) + ());
      return 2;
    }
  }
}