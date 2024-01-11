using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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

    public IActionResult Index()
    {
        return View();
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
            return View("Index");
        }
        FakePetDb.Add(newPet);
        // Console.WriteLine($"{newPet.Name} is a {newPet.Age} year(s) old {newPet.Species} -- they {(newPet.IsCute ? "are" : "aren't")} cute");
        return RedirectToAction("AllPets");
    }

    [HttpGet("pets")]
    public ViewResult AllPets()
    {
        return View("AllPets",FakePetDb);
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
