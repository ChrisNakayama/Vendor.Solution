using Microsoft.VisualStudio.TestTools.UnitTesting;
using PVOT.Models;
using System.Collections.Generic;
using System;

namespace PVOT.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}
  
