using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EspacioPresupuestoDetalle;

namespace EspacioProducto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private static List<Producto> _productos = new();
        public ProductoController()
        {

        }

        [HttpPost("Producto")]
        public ActionResult CrearProducto([FromBody] Producto producto)
        {
            if (producto == null)
            {
                return BadRequest("El producto no puede ser nulo.");
            }
            _productos.Add(producto);
            return CreatedAtAction(nameof(CrearProducto), new { id = producto.IdProducto }, producto);
        }

        [HttpGet("Producto")]
        public ActionResult<List<Producto>> GetProductos()
        {
            return Ok(_productos);
        }

        [HttpPut("Producto/{id}")]
        public ActionResult ModificarProducto(int idProducto,[FromBody] string nuevaDesc)
        {
            var productoBuscado = _productos.FirstOrDefault(p => p.IdProducto == idProducto);
            if (productoBuscado == null)
            {
               return NotFound("Producto no encontrado.");
            }
            productoBuscado.Descripcion = nuevaDesc;
            return NoContent();
        }
    }
}