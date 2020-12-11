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
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(2, testPastry.PastryPrice());
    }
    [TestMethod]
    public void CostOfPastry_ReturnCostOfPastryUserEntered_10()
    {
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(10, testPastry.CostOfPastry());
    }
    [TestMethod]
    public void GroupsOfThree_ReturnNumberOfGroupsOfThreeOfPastries_1()
    {
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(1, testPastry.GroupsOfThree());
    }
    [TestMethod]
    public void EveryTheeForFive_ReturnCostOfPastryTriosWithEveryTrioAsFive_5()
    {
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(5, testPastry.EveryThreeForFive());
    }
    [TestMethod]
    public void AddRemainder_ReturnCostOfPastriesWithTriosAndRemainder_9()
    {
      Pastry testPastry = new Pastry(5);
      Assert.AreEqual(9, testPastry.AddRemainder());
    }
  }
}