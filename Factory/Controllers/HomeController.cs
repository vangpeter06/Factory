using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {
      private readonly FactoryContext _db;

      public HomeController(FactoryContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.EngineerInventory = new List<Engineer>(_db.Engineers.OrderBy(engineer => engineer.Name));
        ViewBag.MachineInventory = new List<Machine>(_db.Machines.OrderBy(machine => machine.Name));
        return View();
      }

    }
}