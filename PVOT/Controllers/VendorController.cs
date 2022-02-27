using Microsoft.AspNetCore.Mvc;
using PVOT.Models;
using System;
using System.Collections.Generic;

namespace PVOT.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> currentVendors = Vendor.GetAll();
      return View(currentVendors);
    }

  }
}