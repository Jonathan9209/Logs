using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Logs_prueba.Controllers;

[ApiController]
[Route("[controller]")]
public class Logs : ControllerBase
{
    private static readonly string[] Nombres = new[]
    {
        "Jonathan","Carlos"
    };

    private readonly ILogger<Logs> _logger;

    public Logs_prueba(ILogger<Logs> logger) => _logger = logger;

    [HttpGet(Name = "Logs")]
    public IEnumerable<Logs> Get(Enumerable enumerable)
    {
        return (IEnumerable<Logs>)enumerable  {
            Cedula = (index),
            Nombre = Nombres[(Nombres.Length)]
        })
        .ToArray();
    }
}
