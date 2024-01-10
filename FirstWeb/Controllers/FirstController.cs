using Microsoft.AspNetCore.Mvc;

public class FirstController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "Hello from my controller!";
    }

    [HttpGet("two")]
    public string PageTwo()
    {
        return "Well done, two routes unlocked!";
    }

    [HttpGet("param/{id}/{name}")]
    public ViewResult Params(int id, string name)
    {
        ViewBag.Id = id;
        ViewBag.Name = name;
        return View();
    }

    [HttpGet("view")]
    public ViewResult FirstView()
    {
        return View("FirstView");
    }

    [HttpGet("form")]
    public ViewResult Form()
    {
        return View();
    }

    // [HttpPost("process")]
    // public RedirectResult Process(int Id, string Name)
    // {
    //     Console.WriteLine($"{Name} gave id {Id}");
    //     return Redirect("form");
    // }

    // [HttpPost("process")]
    // public RedirectResult Process(int Id, string Name)
    // {
    //     Console.WriteLine($"{Name} gave id {Id}");
    //     return Redirect($"param/{Id}/{Name}");
    // }

    // [HttpPost("process")]
    // public RedirectToActionResult Process(int Id, string Name)
    // {
    //     Console.WriteLine($"{Name} gave id {Id}");
    //     return RedirectToAction("Params", new {id=Id,name=Name});
    // }

    [HttpPost("process")]
    public IActionResult Process(int Id, string Name)
    {
        Console.WriteLine($"{Name} gave id {Id}");
        if (Id == 123)
        {
            return View("SecretPage");
        }
        return RedirectToAction("Params", new {id=Id,name=Name});
    }

    [HttpGet("secret")]
    public ViewResult SecretPage()
    {
        return View();
    }

    [HttpGet("{**path}")]
    public string Lost()
    {
        return "I think you're lost!";
    }



}