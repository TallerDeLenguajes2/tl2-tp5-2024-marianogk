using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EspacioPresupuestoDetalle;

namespace EspacioPresupuesto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PresupuestoController : ControllerBase
    {
        private static Presupuesto _Presupuesto = new Presupuesto();
        public PresupuestoController()
        {

        }
        [HttpGet("GetPresupuesto")]
        public ActionResult<List<Presupuesto>> GetPresupuestos()
        {
            return Ok(_Presupuesto.Detalles);
        }
    }
}