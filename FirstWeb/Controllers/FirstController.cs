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

    [HttpGet("{**path}")]
    public string Lost()
    {
        return "I think you're lost!";
    }

}