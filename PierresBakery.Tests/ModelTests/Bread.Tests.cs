using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public int[] InputReturn_ReturnGivenInput_7and5()
    {
      int[] arr = new int[] {7, 5};
      return arr;
    }
  }
    
}