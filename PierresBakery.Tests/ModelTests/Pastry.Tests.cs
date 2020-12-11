using Microsoft.VisualStudio.TestTools.UnitTesting;
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
  }
}