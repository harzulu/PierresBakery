using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void InputReturn_ReturnGivenInput_7()
    {
      int num = 12;
      Bread testBread = new Bread();
      Assert.AreEqual(7, testBread.InputReturn(num));

    }
  }
    
}