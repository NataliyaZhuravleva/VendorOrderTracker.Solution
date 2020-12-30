using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Standard", "Standard order bread", 3.5F, "01/01/2020");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title1 = "Standard";
      string description1 = "Standard order bread";
      float price1 = 3.5F;
      string date1 = "01/01/2020";
      Order newOrder1 = new Order(title1, description1, price1, date1);

      string title2 = "Expanded";
      string description2 = "Expanded order bread and pastry";
      float price2 = 8.99F;
      string date2 = "01/02/2020";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}