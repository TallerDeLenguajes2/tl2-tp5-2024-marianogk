using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EspacioPresupuestoDetalle;

namespace EspacioProducto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private static Producto _Productos = new Producto();
        public ProductoController()
        {

        }

        [HttpGet("Producto")]
        public ActionResult<List<Producto>> GetProductos()
        {
            return Ok(_Productos);
        }
    }
}