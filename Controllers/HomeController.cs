using System.Net;
using System.Threading.Tasks;
using System.Security;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;
using System.Resources;
using System;
using System.Diagnostics;
using System.IO.Compression;
using TPEquiposJugadores.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Reflection.PortableExecutable;

namespace TPEquiposJugadores.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Equipos = BD.ObtenerEquipos();
        return View();
    }

    [HttpGet]
    public IActionResult Equipo(int idEquipo)
    {
        ViewBag.Equipo = BD.ObtenerEquipo(idEquipo);
        ViewBag.Jugadores = BD.ObtenerJugadores(idEquipo);
        return View();
    }

    [HttpPost]
    public Jugador ObtenerJugador(int idJugador){
        return BD.ObtenerJugador(idJugador);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
