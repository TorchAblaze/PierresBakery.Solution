using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresMenu.Models;
using System;
using System.Collections.Generic;

namespace PierresMenu.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }
    [TestMethod]
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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_PastryList()
    {
      List<Pastry> newList = new List<Pastry> {};
      List<Pastry> result = Pastry.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsPastryOrders_PastryList()
    {
      int pastryAmount1 = 1;
      int pastryAmount2 = 3;
      Pastry newPastryOrder1 = new Pastry(pastryAmount1);
      Pastry newPastryOrder2 = new Pastry(pastryAmount2);
      List<Pastry> newList = new List<Pastry> { newPastryOrder1, newPastryOrder2 };
      List<Pastry> result = Pastry.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void OrderTotal_ReturnsCostOfOrder_Int()
    {
      Pastry newPastryOrder = new Pastry(1);
      int result = newPastryOrder.OrderTotal();
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void OrdetTotal_ReturnsReducedCostOfOrder_Int()
    {
      Pastry newPastryOrder = new Pastry(10);
      int result = newPastryOrder.OrderTotal();
      Assert.AreEqual(17, result);
    }
  }
}