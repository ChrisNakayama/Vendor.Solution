using Microsoft.VisualStudio.TestTools.UnitTesting;
using PVOT.Models;
using System.Collections.Generic;
using System;

namespace PVOT.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CheckTypeOrder_Order()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Assert.AreEqual("Order 1", newOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Assert.AreEqual("10 bread, 50 pastries", newOrder.Description);
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Double()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Assert.AreEqual(45.00, newOrder.Price);
    }
    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Assert.AreEqual("2022-02-25", newOrder.Date);
    }
    [TestMethod]
    public void GetId_ReturnId_Integer()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Assert.AreEqual(1, newOrder.Id);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrdersList()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Order anotherOrder = new Order("Order 2", "5 bread, 25 pastries", 22.50, "2022-02-26");
      List<Order> allOrders = new List<Order> {newOrder, anotherOrder};
      CollectionAssert.AreEqual(allOrders, Order.GetAll());
    }
    [TestMethod]
    public void Find_ReturnsSpecificOrder_Order()
    {
      Order newOrder = new Order("Order 1", "10 bread, 50 pastries", 45.00, "2022-02-25");
      Order anotherOrder = new Order("Order 2", "5 bread, 25 pastries", 22.50, "2022-02-26");
      Assert.AreEqual(newOrder, Order.Find(1));
    }
  }
  }