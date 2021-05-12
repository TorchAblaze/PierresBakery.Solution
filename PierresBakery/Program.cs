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
      Console.WriteLine("\nHow can we help you today? (Press 'b' to buy bread, 'p' to buy pastries or 'e' to complete your order and exit)");
      string productType = Console.ReadLine().ToLower();
      while (productType != "e" || productType != "exit")
      {
        if (productType.Contains("b"))
        {
          Console.WriteLine("\nYou chose to buy bread! Bread prices are: Buy 2, get 1 free.\nPlease enter the amount of loaves you would like to buy today: ");
          try
          {
            int breadAmount = int.Parse(Console.ReadLine());
            while (breadAmount < 0)
            {
              Console.WriteLine($"That was an invalid response. Please try again.");
              Console.WriteLine("\nYou chose to buy bread! Bread prices are: Buy 2, get 1 free.\nPlease enter the amount of loaves you would like to buy today: ");
              breadAmount = int.Parse(Console.ReadLine());
            }
            string loafWord = Program.pluralize("loaves", "loaf", breadAmount);
            Bread breadOrder = new Bread(breadAmount);
            total += breadOrder.OrderTotal();
            Console.WriteLine($"\nYou ordered {breadAmount} {loafWord} of bread! Your total for this order is ${breadOrder.OrderTotal()}.00.\n");

            Console.WriteLine("\nHow can we help you today? (Press 'b' to buy bread, 'p' to buy pastries or 'e' to exit)");
            productType = Console.ReadLine().ToLower();
          }
          catch (Exception)
          {
            Console.WriteLine($"That was an invalid response. Please try again.");

          }
        }
        else if (productType.Contains("p"))
        {
          Console.WriteLine("\nYou chose to buy pastries! Pastry prices are: Buy 1 for $2 or 3 for $5\nPlease enter the amount of pastries you would like to buy today: ");
          try
          {
            int pastryAmount = int.Parse(Console.ReadLine());
            while (pastryAmount < 0)
            {
              Console.WriteLine($"That was an invalid response. Please try again.");
              Console.WriteLine("\nYou chose to buy pastries! Pastry prices are: Buy 1 for $2 or 3 for $5\nPlease enter the amount of pastries you would like to buy today: ");
              pastryAmount = int.Parse(Console.ReadLine());
            }
            string pastryWord = Program.pluralize("pastries", "pastry", pastryAmount);
            Pastry pastryOrder = new Pastry(pastryAmount);
            Console.WriteLine($"\nYou ordered {pastryAmount} {pastryWord}! Your total for this order is ${pastryOrder.OrderTotal()}.00.\n");
            total += pastryOrder.OrderTotal();

            Console.WriteLine("\nHow can we help you today? (Press 'b' to buy bread, 'p' to buy pastries or 'e' to exit)");
            productType = Console.ReadLine().ToLower();
          }
          catch (Exception)
          {
            Console.WriteLine($"That was an invalid response. Please try again.");
          }
        }
        else if (productType.Contains("e"))
        {
          break;
        }
        else
        {
          Console.WriteLine("That was an invalid response :(");
          Console.WriteLine("\nHow can we help you today? (Press 'b' to buy bread, 'p' to buy pastries or 'e' to exit)");
          productType = Console.ReadLine().ToLower();
        }
      }
      Console.WriteLine($"\nYour total for today is ${total}.00\nThank you for stopping by!\n\n\nPierre's Bakery kneads customers like you to keep breadness on the rise :)");
    }
  }
}