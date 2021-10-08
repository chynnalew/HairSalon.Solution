
using HairSalon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistController : Controller
  {
    private readonly HairSalonContext _db;
    public StylistController(HairSalonContext db)
    {
      _db =db;
    }
    
    public ActionResult Index()
    {
      List<Stylist> stylistList = _db.Stylists.ToList();
      return View(stylistList); 
    }
  }
}