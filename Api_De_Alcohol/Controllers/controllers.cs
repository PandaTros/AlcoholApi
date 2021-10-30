using System;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using AppAlcohol.Domain;

namespace AppAlcohol.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class controller : ControllerBase
    {
        [HttpGet]
        [Route("CalcularCntAlcohol/{bebida}/{cantidad}/{peso}")]
        public IActionResult ValorAlcholimetro (string bebida, int cantidad, double peso)                         
        {
            var eth = new controllers();
            var rst = eth.calcular(bebida, cantidad, peso);
            return Ok($"La cantidad de alcohol es;{rst}");
        }
    }
}