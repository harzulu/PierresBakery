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
  }
    
}