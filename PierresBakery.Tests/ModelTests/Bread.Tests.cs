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
      int num = 7;
      Bread testBread = new Bread();
      Assert.AreEqual(7, testBread.InputReturn(num));
    }
    [TestMethod]
    public void BreadPrice_ReturnPriceOfBread_5()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.BreadPrice());
    }
    [TestMethod]
    public void CostOfBread_ReturnCostOfBreadUserEntered_35()
    {
      int userVal = 7;
      Bread testBread = new Bread();
      Assert.AreEqual(35, testBread.CostOfBread(userVal));
    }
    [TestMethod]
    public void GroupsOfThree_ReturnNumberOfGroupsOfThreeOfBread_2()
    {
      int userVal = 7;
      Bread testBread = new Bread();
      Assert.AreEqual(2, testBread.GroupsOfThree(userVal));
    }
    [TestMethod]
    public void EveryThirdFree_ReturnCostOfBreadTriosWithEveryThirdFree_20()
    {
      int userVal = 7;
      Bread testBread = new Bread();
      Assert.AreEqual(20, testBread.EveryThirdFree(userVal));
    }
  }
    
}