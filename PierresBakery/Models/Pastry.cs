using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryPrice()
    {
      return 2;
    }

    public int CostOfPastry(int val)
    {
      return val * 2;
    }

        public int GroupsOfThree(int val)
    {
      return val / 3;
    }

    public int EveryThreeForFive(int val)
    {
      int trios = GroupsOfThree(val);

      return trios * 5;
    }

    public int AddRemainder(int val)
    {
      int remainder = val % 3;

      return EveryThreeForFive(val) + (remainder * 2);
    }
  }
}