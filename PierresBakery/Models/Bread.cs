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
      return val / 6;
    }
  }
}