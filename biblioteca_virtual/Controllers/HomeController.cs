using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using biblioteca_virtual.Models;
using biblioteca_virtual.Data;
using Microsoft.EntityFrameworkCore;
using biblioteca_virtual.ViewModels;

namespace biblioteca_virtual.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _contexto;

    public HomeController(ILogger<HomeController> logger, AppDbContext contexto)
    {
        _logger = logger;
        _contexto = contexto;
    }

    public IActionResult Index()
    {
        HomeVM homeVM = new()
        {
            Generos = _contexto.Generos.ToList(),
            Livros = _contexto.Livros
            .Include(l => l.Autor)
            .Include(l => l.Genero)
            .ToList()
        };
        return View(homeVM);
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
