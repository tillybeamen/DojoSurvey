﻿#pragma warning disable CS8618
// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using DojoSurvey.Models;

// namespace DojoSurvey.Controllers;
// public class HomeController : Controller
// {
//     static Survey student;
//     private readonly ILogger<HomeController> _logger;

//     public HomeController(ILogger<HomeController> logger)
//     {
//         _logger = logger;
//     }

//     [HttpGet("")]
//     public IActionResult Index()
//     {
//         return View();
//     }


//     [HttpPost("addStudent")]
//     public IActionResult AddStudent(Survey student) 
//     {
//         System.Console.WriteLine(student.Name);
//         System.Console.WriteLine(student.Location);
//         System.Console.WriteLine(student.Language);
//         System.Console.WriteLine(student.Comment);
//         // ViewBag.Name = Name;
//         // ViewBag.Location = Location;
//         // ViewBag.Language = Language;
//         // ViewBag.Comment = Comment;

//         // To replace ViewBag with View model try this
//         // int MyNumber = 7;
//         // return View(MyNumber)
//         return View("Results");
//     }
//     public IActionResult Privacy()
//     {
//         return View();
//     }

//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{

    static Survey NewUser;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("addStudent")]
    public IActionResult Process(Survey user)
    {
        NewUser = user;
        return RedirectToAction("Results");
    }

    [HttpGet("results")]
    public IActionResult Results()
    {
        return View(NewUser);
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