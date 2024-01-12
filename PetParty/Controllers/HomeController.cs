using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetParty.Models;

namespace PetParty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<Pet> FakePetDb = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() //this route is rendering our form
    {
        ViewBag.Choices = new List<SelectListItem>()
        {
            new SelectListItem("---choose---","",true,true),
            new SelectListItem("Bear", "Bear"),
            new SelectListItem("Deer", "Deer"),
            new SelectListItem("Bobcat", "Bobcat")
        };
        return View("Index");
    }

    [HttpPost("pets/create")]
    public IActionResult CreatePet(Pet newPet)
    {
        if (!ModelState.IsValid)
        {
            var message = string.Join(" | ", ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage));
            Console.WriteLine(message);
        }

        if (!ModelState.IsValid)
        {
            return Index();
        }
        FakePetDb.Add(newPet);
        HttpContext.Session.SetString("LastPet", newPet.Name);
        // Console.WriteLine($"{newPet.Name} is a {newPet.Age} year(s) old {newPet.Species} -- they {(newPet.IsCute ? "are" : "aren't")} cute");
        return RedirectToAction("AllPets");
    }

    [HttpGet("pets")]
    public IActionResult AllPets()
    {
        // string? LastPet = HttpContext.Session.GetString("LastPet");
        if (HttpContext.Session.GetString("LastPet") == null)
        {
            return RedirectToAction("Index");
        }
        return View("AllPets",FakePetDb);
    }

    [HttpPost("pets/filter/")]
    public RedirectToActionResult SetFilter(int limit)
    {
        HttpContext.Session.SetInt32("Limit", limit);
        return RedirectToAction("AllPets");
    }

    [HttpGet("pets/filter/{limit}")]
    public RedirectToActionResult SetFilterParam(int limit)
    {
        HttpContext.Session.SetInt32("Limit", limit);
        return RedirectToAction("AllPets");
    }

    [HttpPost("pets/filter/clear")]
    public RedirectToActionResult ClearFilter()
    {
        // HttpContext.Session.Clear(); // this will clear session completely
        HttpContext.Session.Remove("Limit");
        return RedirectToAction("AllPets");

    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
