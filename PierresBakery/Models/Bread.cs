using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int InputReturn(int num)
    {
    return num;
    }

    public int BreadPrice()
    {
      return 5;
    }

    public int CostOfBread(int val)
    {
      return val * 5;
    }

    public int GroupsOfThree(int val)
    {
      return val / 3;
    }

    public int EveryThirdFree(int val)
    {
      int trios = GroupsOfThree(val);
      int bread = trios * 3;

      return CostOfBread(bread - trios);
    }

    public int AddRemainder(int val)
    {
      int reamainder = val % 3;

      return EveryThirdFree(val) + (reamainder * 5);
    }
  }
}