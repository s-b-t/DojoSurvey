using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers;

public class DojoSurveyController : Controller
{
    [HttpGet("")]
    public ViewResult Home()
    {
        return View("Home");
    }

    // Post method
    [HttpPost("process")]
    public IActionResult Process(string name, string dojoLocation, string favLanguage, string comment)
    {    
        // Show form input in console
        Console.WriteLine($"My name was: {name}");
        Console.WriteLine($"My dojoLocation was: {dojoLocation}");
        Console.WriteLine($"My favLanguage was: {favLanguage}");
        Console.WriteLine($"My comment was: {comment}");
        return RedirectToAction("Results", new {name=name, dojoLocation=dojoLocation, favLanguage=favLanguage, comment=comment});
    }

    [HttpGet("results")]
    public IActionResult Results(string name, string dojoLocation, string favLanguage, string comment)
    {
        // Console.WriteLine(name);
        ViewBag.name = name;
        ViewBag.dojoLocation = dojoLocation;
        ViewBag.favLanguage = favLanguage;
        ViewBag.comment = comment;
        return View("Results");
    }
}