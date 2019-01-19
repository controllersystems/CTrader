using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CTrader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DicasController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("semana")]
        public ActionResult<string> Semana()
        {
            return "Dicas da semana";
        }

        [HttpGet("dia")]
        public ActionResult<string> Dia()
        {
            return "Dicas do dia";
        }

        [HttpGet("mes")]
        public ActionResult<string> Mes()
        {
            return "Dicas do mes";
        }
    }
}
