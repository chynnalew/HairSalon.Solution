using HairSalon.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;
    public ClientsController(HairSalonContext db)
    {
      _db =db;
    }
    
    public ActionResult Index()
    {
      List<Client> clientList = _db.Clients.Include(item => item.Stylist).ToList();
      return View(clientList);
    }
    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index", "Stylists");
    }

    public ActionResult Details(int id)
    {
      Client client = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(client);
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client thisClient)
    {
      _db.Entry(thisClient).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}