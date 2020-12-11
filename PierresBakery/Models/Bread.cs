using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumOfBread { get; set; }

    public Bread(int val)
    {
      NumOfBread = val;
    }
    public int InputReturn()
    {
    return NumOfBread;
    }

    public int BreadPrice()
    {
      return 5;
    }

    public int CostOfBread()
    {
      return NumOfBread * 5;
    }

    public int GroupsOfThree()
    {
      return NumOfBread / 3;
    }

    public int EveryThirdFree()
    {
      int trios = GroupsOfThree();
      int bread = trios * 3;

      return (bread - trios) * 5;
    }

    public int AddRemainder()
    {
      int reamainder = NumOfBread % 3;

      return EveryThirdFree() + (reamainder * 5);
    }
  }
}