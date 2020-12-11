using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumOfPastry { get; set; }

    public Pastry(int val)
    {
      NumOfPastry = val;
    }
    public int PastryPrice()
    {
      return 2;
    }

    public int CostOfPastry()
    {
      return NumOfPastry * 2;
    }

        public int GroupsOfThree()
    {
      return NumOfPastry / 3;
    }

    public int EveryThreeForFive()
    {
      int trios = GroupsOfThree();

      return trios * 5;
    }

    public int AddRemainder()
    {
      int remainder = NumOfPastry % 3;

      return EveryThreeForFive() + (remainder * 2);
    }
  }
}