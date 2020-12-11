using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryPrice_ReturnPriceOfOnePastry_2()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2, testPastry.PastryPrice());
    }
    [TestMethod]
    public void CostOfPastry_ReturnCostOfPastryUserEntered_10()
    {
      int userVal = 5;
      Pastry testPastry = new Pastry();
      Assert.AreEqual(10, testPastry.CostOfPastry(userVal));
    }
    [TestMethod]
    public void GroupsOfThree_ReturnNumberOfGroupsOfThreeOfPastries_1()
    {
      int userVal = 5;
      Pastry testPastry = new Pastry();
      Assert.AreEqual(1, testPastry.GroupsOfThree(userVal));
    }
    [TestMethod]
    public void EveryTheeForFive_ReturnCostOfPastryTriosWithEveryTrioAsFive_5()
    {
      int userVal = 5;
      Pastry testPastry = new Pastry();
      Assert.AreEqual(5, testPastry.EveryThreeForFive(userVal));
    }
  }
}