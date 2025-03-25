using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeekDay.Models;

namespace WeekDay.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public string GetIf(int x)
    {
        string retorno = string.Empty;


        int[] array = new int[5];
        string[] weekDays = ["Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado", "Domingo"];

        if (x == 1)
            retorno = weekDays[0];
        else if (x == 2)
            retorno = weekDays[1];
        else if (x == 3)
            retorno = weekDays[2];
        else if (x == 4)
            retorno = weekDays[3];
        else if (x == 5)
            retorno = weekDays[4];
        else if (x == 6)
            retorno = weekDays[5];
        else if (x == 7)
            retorno = weekDays[6];
        else
        {
            retorno = "Putz ";
            retorno += "Dia inválido";
        }

            return retorno;
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
