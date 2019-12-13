using System;
using swapi01.Models;
using Microsoft.AspNetCore.Mvc;

public IActionResult Test()
{
    ViewData["Message"] = "This is a test";
    return View();
}

public IActionResult Index() {
    var person = new Person() {
        Name = "Will Olewnicki",
        Age = 17
    };
    ViewData["Person"] = person;
    return View();
}
