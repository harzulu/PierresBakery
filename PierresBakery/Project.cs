using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main()
    {
      List<int> totals = new List<int> {};
      bool buyMore = true;
      int counter = 0;

      Console.WriteLine("Welcome to Pierre's Bakery!");
      while (buyMore == true)
      {
        Console.WriteLine("Bread is $5 a loaf, but there is a sale for buy 2 get one free!");
        Console.WriteLine("Pastries are $2 each, but also on a sale 3 for $5!");
        Console.WriteLine("How many loaves of bread would you like to buy?");
        int breadAmmount = int.Parse(Console.ReadLine());
        Bread breadClass = new Bread(breadAmmount);

        Console.WriteLine("How many pastries would you like?");
        int pastryAmmount = int.Parse(Console.ReadLine());
        Pastry pastryClass = new Pastry(pastryAmmount);

        totals.Add(breadClass.AddRemainder() + pastryClass.AddRemainder());

        Console.WriteLine("Your total for bread is: $" + breadClass.AddRemainder() + ".");
        Console.WriteLine("And your total for pastries is: $" + pastryClass.AddRemainder() + ".");
        Console.WriteLine("Your total for both is: $" + totals[counter] + ".");
        Console.WriteLine("Would you like to buy more? Y/N");
        string buyMoreAnswer = Console.ReadLine();

        if (buyMoreAnswer == "Y")
        {
          buyMore = true;
          counter++;
        } else
        {
          int grandTotal = 0;
          for (int i = 0; i <= counter; i++)
          {
            grandTotal += totals[i];
          }
          Console.WriteLine("Your total for both is: $" + grandTotal + ".");
          buyMore = false;
        }
      }

      Console.WriteLine("Would you like to shop again? Y/N");
      string continueAnswer = Console.ReadLine();

      if (continueAnswer == "Y")
      {
        Program.Main();
      } else
      {
        Console.WriteLine("Have a great day!");
      }
    }
  }
}