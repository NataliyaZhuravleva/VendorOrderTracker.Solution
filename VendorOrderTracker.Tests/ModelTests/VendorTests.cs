using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTest
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor=new Vendor("test vendor", "test vendor description");
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

      Assert.AreEqual(1,result);
    }
  }
}