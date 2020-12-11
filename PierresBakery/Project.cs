using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread is $5 a loaf, but there is a sale for buy 2 get one free!");
      Console.WriteLine("Pastries are $2 each, but also on a sale 3 for $5!");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      int breadAmmount = int.Parse(Console.ReadLine());
      Bread breadClass = new Bread(breadAmmount);

      Console.WriteLine("How many pastries would you like?");
      int pastryAmmount = int.Parse(Console.ReadLine());
      Pastry pastryClass = new Pastry(pastryAmmount);

      Console.WriteLine("Your total for bread is: $" + breadClass.AddRemainder() + ".");
      Console.WriteLine("And your total for pastries is: $" + pastryClass.AddRemainder() + ".");
      Console.WriteLine("Your total today is: $" + (breadClass.AddRemainder() + pastryClass.AddRemainder()) + ".");
    }
  }
}