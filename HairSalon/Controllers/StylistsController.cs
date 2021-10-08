
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
      dynamic myModel = new ExpandoObject();
      myModel.Client = _db.Clients.Where(client => client.StylistId == id).ToList();
      myModel.Stylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(myModel);
    }

    public ActionResult Edit(int id)
    {
      var thisStylist = _db.Clients.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist thisStylist)
    {
      _db.Entry(thisStylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}