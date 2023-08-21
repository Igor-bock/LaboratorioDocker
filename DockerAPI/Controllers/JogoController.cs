using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DockerAPI.Models;

namespace DockerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JogoController : Controller
{
    public TesteDbContext? C_Context { get; set; }

    public JogoController(TesteDbContext p_Context)
    {
        C_Context = p_Context;
    }

    ~JogoController()
    {
        if (C_Context != null)
            C_Context.Dispose();
    }

    [HttpPost]
    public async Task Inserir(Jogo p_Jogo)
    {
        C_Context!.Jogos.Add(p_Jogo);
        await C_Context.SaveChangesAsync();
    }

    [HttpGet]
    public IEnumerable<Jogo> Buscar()
    {
        return C_Context!.Jogos.ToList();
    }
}
