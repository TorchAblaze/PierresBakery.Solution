using System;
using PierresMenu.Models;

namespace PierresMenu 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine(@"****************************************************************************************
           
                          Welcome to Pierre's Bakery!
          The best in the breadness for bread loave(r)s everywhere :D

Due to the effects of Covid 19, we are only offering bread and pastries at the moment.

              Bread: Buy 2, get 1 free! A single loaf costs $5
              Pastry: Buy 1 for $2 or 3 for $5

****************************************************************************************");

      Console.WriteLine("\nHow can we help you today? (Press 'b' to buy bread or 'p' to buy pastries)");
      string productType = Console.ReadLine().ToLower();
      if (productType.Contains("b"))
      {
        Console.WriteLine("\nYou've chosen to buy bread! Bread prices are: Buy 2, get 1 free.\nPlease enter the amount of loaves you would like to buy today: ");
        int breadAmount = int.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(breadAmount);
        Console.WriteLine($"\nYou've ordered {breadAmount} loaves of bread! Your total is ${breadOrder.OrderTotal()}.00.\n");
      }
      else if (productType.Contains("p"))
      {
        Console.WriteLine("\nYou've chosen to buy pastries! Pastry prices are: Buy 1 for $2 or 3 for $5\nPlease enter the amount of pastries you would like to buy today: ");
        int pastryAmount = int.Parse(Console.ReadLine());
        Pastry pastryOrder = new Pastry(pastryAmount);
        Console.WriteLine($"\nYou've ordered {pastryAmount} pastries! Your total is ${pastryOrder.OrderTotal()}.00.\n");
      }
      else
      {
        Console.WriteLine("That was an invalid response :(");
      }
    }
  }
}