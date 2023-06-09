﻿#pragma warning disable CS8618

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
        if(ModelState.IsValid)
        {
            return RedirectToAction("Results");
        }
        else
        {
        return View("Index");

        }
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