
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;
    public StylistsController(HairSalonContext db)
    {
      _db =db;
    }

    public ActionResult Index()
    {
      List<Stylist> stylistList = _db.Stylists.ToList();
      return View(stylistList); 
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      List<Client> clientList = _db.Clients.Where(client => client.StylistId == id).ToList();
      ViewBag.Stylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(clientList);
    }
  }
}