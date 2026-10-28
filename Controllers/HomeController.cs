using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ProjectAdmin.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Fibonacci(int count)
    {
        if (count <= 0)
        {
            return Json(new List<int>());
        }

        var series = new List<int>();
        int first = 0;
        int second = 1;

        for (int i = 0; i < count; i++)
        {
            series.Add(first);

            int next = first + second;
            first = second;
            second = next;
        }

        return Json(series);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View();
    }
}
