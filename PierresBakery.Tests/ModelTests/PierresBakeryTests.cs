using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMenu.Models;

namespace PierresMenu.Test
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBreadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    // Tests
  }
}