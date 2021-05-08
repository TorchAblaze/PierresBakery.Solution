using System;
using PierresMenu.Models;

namespace PierresMenu 
{
  
  public class Program
  {
    public static string pluralize(string pluralNoun, string singularNoun, int amount)
    {
      if (amount == 1)
      {
        return singularNoun;
      }
      else
      {
        return pluralNoun;
      }
    }
    public static void Main()
    {
      int total = 0;

      Console.WriteLine(@"****************************************************************************************
           
                          Welcome to Pierre's Bakery!
          The best in the breadness for bread loave(r)s everywhere :D

Due to the effects of Covid 19, we are only offering bread and pastries at the moment.

              Bread: Buy 2, get 1 free! A single loaf costs $5
              Pastry: Buy 1 for $2 or 3 for $5

****************************************************************************************");

      for (int index = 1; index < 3; index++)
      {
        Console.WriteLine("\nHow can we help you today? (Press 'b' to buy bread or 'p' to buy pastries)");
        string productType = Console.ReadLine().ToLower();
        if (productType.Contains("b"))
        {
          Console.WriteLine("\nYou've chosen to buy bread! Bread prices are: Buy 2, get 1 free.\nPlease enter the amount of loaves you would like to buy today: ");
          int breadAmount = int.Parse(Console.ReadLine());
          string loafWord = Program.pluralize("loaves", "loaf", breadAmount);
          Bread breadOrder = new Bread(breadAmount);
          total += breadOrder.OrderTotal();
          Console.WriteLine($"\nYou've ordered {breadAmount} {loafWord} of bread! Your total for this order is ${breadOrder.OrderTotal()}.00.\n");
        }
        else if (productType.Contains("p"))
        {
          Console.WriteLine("\nYou've chosen to buy pastries! Pastry prices are: Buy 1 for $2 or 3 for $5\nPlease enter the amount of pastries you would like to buy today: ");
          int pastryAmount = int.Parse(Console.ReadLine());
          string pastryWord = Program.pluralize("pastries", "pastry", pastryAmount);
          Pastry pastryOrder = new Pastry(pastryAmount);
          Console.WriteLine($"\nYou've ordered {pastryAmount} {pastryWord}! Your total for this order is ${pastryOrder.OrderTotal()}.00.\n");
          total += pastryOrder.OrderTotal();
        }
        else
        {
          Console.WriteLine("That was an invalid response :(");
        }
      }
      Console.WriteLine($"Your entire order for today is ${total}.00\n");
    }
  }
}