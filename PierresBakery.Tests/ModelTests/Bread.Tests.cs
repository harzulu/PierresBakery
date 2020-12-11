using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void InputReturn_ReturnGivenInput_7()
    {
      Bread testBread = new Bread(7);
      Assert.AreEqual(7, testBread.InputReturn());
    }
    [TestMethod]
    public void BreadPrice_ReturnPriceOfBread_5()
    {
      Bread testBread = new Bread(7);
      Assert.AreEqual(5, testBread.BreadPrice());
    }
    [TestMethod]
    public void CostOfBread_ReturnCostOfBreadUserEntered_35()
    {
      Bread testBread = new Bread(7);
      Assert.AreEqual(35, testBread.CostOfBread());
    }
    [TestMethod]
    public void GroupsOfThree_ReturnNumberOfGroupsOfThreeOfBread_2()
    {
      Bread testBread = new Bread(7);
      Assert.AreEqual(2, testBread.GroupsOfThree());
    }
    [TestMethod]
    public void EveryThirdFree_ReturnCostOfBreadTriosWithEveryThirdFree_20()
    {
      Bread testBread = new Bread(7);
      Assert.AreEqual(20, testBread.EveryThirdFree());
    }
    [TestMethod]
    public void AddRemainder_ReturnCostOfBreadWithTriosAndRemainder_25()
    {
      Bread testBread = new Bread(7);
      Assert.AreEqual(25, testBread.AddRemainder());
    }
  }
    
}