using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMenu.Models;

namespace PierresMenu.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    
    [TestMethod]
    public void GetAmount_ReturnsBreadAmount_Int()
    {
      int breadAmount = 1;
      Bread newBreadOrder = new Bread(breadAmount);
      int result = newBreadOrder.Amount;
      Assert.AreEqual(breadAmount, result);
    }
  }
}