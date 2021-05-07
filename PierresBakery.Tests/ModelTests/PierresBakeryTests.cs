using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMenu.Models;
using System;
using System.Collections.Generic;

namespace PierresMenu.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
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
    [TestMethod]
    public void SetAmount_SetAmount_Int()
    {
      int breadAmount = 2;
      Bread newBreadOrder = new Bread(breadAmount);
      int updatedAmount = 3;
      newBreadOrder.Amount = updatedAmount;
      int result = newBreadOrder.Amount;
      Assert.AreEqual(updatedAmount, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_BreadList()
    {
      List<Bread> newList = new List<Bread> {};
      List<Bread> result = Bread.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsBreadOrders_BreadList()
    {
      int breadAmount1 = 1;
      int breadAmount2 = 3;
      Bread newBreadOrder1 = new Bread(breadAmount1);
      Bread newBreadOrder2 = new Bread(breadAmount2);
      List<Bread> newList = new List<Bread> { newBreadOrder1, newBreadOrder2 };
      List<Bread> result = Bread.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void OrderTotal_ReturnsCostOfOrder_Int()
    {
      Bread newBreadOrder = new Bread(1);
      int result = newBreadOrder.OrderTotal();
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void OrderTotal_ReturnsReducedCostOfOrder_Int()
    {
      Bread newBreadOrder = new Bread(15);
      int result = newBreadOrder.OrderTotal();
      Assert.AreEqual(50, result);
    }
  }
  [TestClass]
  public class PastryTests
  {
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastryOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
    [TestMethod]
    public void GetAmount_ReturnsPastryAmount_Int()
    {
      int pastryAmount = 1;
      Pastry newPastryOrder = new Pastry(pastryAmount);
      int result = newPastryOrder.Amount;
      Assert.AreEqual(pastryAmount, result);
    }
    [TestMethod]
    public void SetAmount_SetAmount_Int()
    {
      int pastryAmount = 2;
      Pastry newPastryOrder = new Pastry(pastryAmount);
      int updatedAmount = 3;
      newPastryOrder.Amount = updatedAmount;
      int result = newPastryOrder.Amount;
      Assert.AreEqual(updatedAmount, result);
    }
  }
}