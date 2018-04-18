using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TamagotchiPet.Models;

namespace TamagotchiPet.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/tamagotchies")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamagotchies = Tamagotchi.GetAll();
      return View(allTamagotchies);
    }

    [HttpGet("/tamagotchies/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/tamagotchies")]
    public ActionResult Create()
    {
      Tamagotchi newTamagotchi = new Tamagotchi(Request.Form["new-tamagotchi"]);

      List<Tamagotchi> allTamagotchies = Tamagotchi.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpGet("/feed/{id}")]
    public ActionResult Index1(int id)
    {
      Tamagotchi.Find(id).GiveFood();
      List<Tamagotchi> allTamagotchies = Tamagotchi.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpGet("/sleep/{id}")]
    public ActionResult Index2(int id)
    {
      Tamagotchi.Find(id).GiveRest();
      List<Tamagotchi> allTamagotchies = Tamagotchi.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpGet("/happy/{id}")]
    public ActionResult Index3(int id)
    {
      Tamagotchi.Find(id).GiveHappiness();
      List<Tamagotchi> allTamagotchies = Tamagotchi.GetAll();
      return View("Index", allTamagotchies);
    }

    [HttpPost("/tamagotchies/decrease")]
        public ActionResult Decrease()
        {
            List<Tamagotchi> allTamagotchies = Tamagotchi.GetAll();
            foreach(Tamagotchi tama in allTamagotchies )
            {
            tama.Timepass();
            }
            return View("Index", allTamagotchies);
        }

  }
}
