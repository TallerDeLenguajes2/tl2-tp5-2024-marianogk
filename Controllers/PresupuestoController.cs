using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EspacioPresupuestoDetalle;

namespace EspacioPresupuesto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PresupuestoController : ControllerBase
    {
        private static List<Presupuesto> _presupuestos = new();
        public PresupuestoController()
        {

        }
        [HttpPost("Presupuesto")]
        public ActionResult CrearPresupuesto([FromBody] Presupuesto presupuesto)
        {
            if (presupuesto == null)
            {
                return BadRequest("El presupuesto no puede ser nulo.");
            }
            _presupuestos.Add(presupuesto);
            return CreatedAtAction(nameof(CrearPresupuesto), new { id = presupuesto.IdPresupuesto }, presupuesto);
        }

        [HttpGet("Presupuesto")]
        public ActionResult<List<Presupuesto>> GetPresupuestos()
        {
            return Ok(_presupuestos);
        }

        [HttpPost("Presupuesto/{id}/ProductoDetalle")]
        public ActionResult ModificarPresupuesto(int id, [FromBody] Producto producto, int cantidad)
        {
            var presupuesto = _presupuestos.FirstOrDefault(p => p.IdPresupuesto == id);

            if (presupuesto == null)
            {
                return NotFound("Presupuesto no encontrado.");
            }

            var detalle = presupuesto.Detalles.FirstOrDefault(d => d.Producto.IdProducto == producto.IdProducto);
            
            if (detalle != null)
            {
                detalle.Cantidad += cantidad; // Si el producto ya existe, actualiza la cantidad
            }
            else
            {
                presupuesto.Detalles.Add(new PresupuestoDetalle(producto, cantidad));
            }

            return Ok(presupuesto);
        }
    }
}