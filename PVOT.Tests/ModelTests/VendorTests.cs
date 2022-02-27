using Microsoft.VisualStudio.TestTools.UnitTesting;
using PVOT.Models;
using System.Collections.Generic;
using System;

namespace PVOT.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
     public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_TypeIsVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Chris N", "Coffee Shop.");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Vendor newVendor = new Vendor("Chris N", "Coffee Shop ");
      Assert.AreEqual("Chris N", newVendor.Name);
    }
    [TestMethod]
    public void SetName_ReturnsUpdatedName_String()
    {
      Vendor newVendor = new Vendor("Chris N", "Coffee Shop");
      newVendor.Name = "Tanner H";
      Assert.AreEqual("Tanner H", newVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Vendor newVendor = new Vendor("Tanner H", "Coffee Shop");
      Assert.AreEqual("Coffee Shop", newVendor.Description);
    }
    [TestMethod]
    public void SetDescription_ReturnsUpdatedDescription_String()
    {
      Vendor newVendor = new Vendor("Tanner H", "Coffee Shop");
      newVendor.Description = "Record Store and Coffee Shop";
      Assert.AreEqual("Record Store and Coffee Shop", newVendor.Description);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor newVendor = new Vendor("Tanner H", "Coffee Shop.");
      Vendor anotherVendor = new Vendor("Jamie P", "Florest");
      List<Vendor> vendorList = new List<Vendor> {newVendor, anotherVendor};
      CollectionAssert.AreEqual(vendorList, Vendor.GetAll());
    }
  }
}
  
