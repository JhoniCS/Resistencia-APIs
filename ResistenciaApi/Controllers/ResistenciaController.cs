/*  Universidad Tecnologica Metropolitana
    Aplicaciones Web Orientadas a Servicios
    Maestro Chuc Uc Joel Ivan
    Actividad 2 (Resistencia y Alcoholimetro API's)
    Jhonatan Canché Sulú
    Cuatrimestre: 4a DSM
    2° Parcial
*/

using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using ResistenciaApi.Application;

namespace ResistenciaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResistenciaController : ControllerBase
    {

        [HttpPost]
        [Route("")]
        public IActionResult Calcular([FromBody] Resistencias res)
        {
            var calculo = new ResistenciasServices();
            var resis = calculo.Calcular(res);
            return Ok(resis);
        }


        [HttpGet]
        [Route("{color1}.{color2}.{color3}.{color4}")]
        public IActionResult Calcular2(string color1, string color2, string color3, string color4)

        {
            var res = new Resistencias(color1, color2, color3, color4);
            var calculo = new ResistenciasServices();
            var resis = calculo.Calcular(res);
            return Ok(resis);
        }
    }
}