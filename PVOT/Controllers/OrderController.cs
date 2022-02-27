using Microsoft.AspNetCore.Mvc;
using PVOT.Models;
using System;
using System.Collections.Generic;

namespace PVOT.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/order/")]
    public ActionResult Index(int vendorId)
    {
      Vendor currentVendor = Vendor.Find(vendorId);
      // Dictionary<string, List<Order>> model = new Dictionary<Vendor, List<Order>> {{currentVendor.Name, currentVendor.Orders}}
      return View(currentVendor);
    }

    [HttpGet("/vendor/{Id}/order/new")]
    public ActionResult New(int Id)
    {
      Vendor currentVendor = Vendor.Find(Id);
      return View(currentVendor);
    }


  }
}