using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      string description = "Test Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "Test Vendor Description";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Test Vendor1";
      string description1 = "Test Vendor Description1";
      Vendor newVendor1 = new Vendor(name1, description1);

      string name2 = "Test Vendor2";
      string description2 = "Test Vendor Description2";
      Vendor newVendor2 = new Vendor(name2, description2);

      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Test Vendor1";
      string description1 = "Test Vendor Description1";
      Vendor newVendor1 = new Vendor(name1, description1);

      string name2 = "Test Vendor2";
      string description2 = "Test Vendor Description2";
      Vendor newVendor2 = new Vendor(name2, description2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
      public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderTitle = "Standard";
      string orderDescription = "Standard order bread";
      float orderPrice = 3.5F;
      string orderDate = "01/01/2020";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      List<Order> newList = new List<Order>{newOrder};

      string vendorName = "Test Vendor";
      string vendorDescription = "Test Vendor Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}
}