using Microsoft.AspNetCore.Mvc;
using GYMSHARK_KC_MVC.Data;
using GYMSHARK_KC_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace GYMSHARK_KC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KCProductosController : ControllerBase
    {
        private readonly KCContext _context;

        public KCProductosController(KCContext context)
        {
            _context = context;
        }

        // Obtener todos los productos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KCProducto>>> GetProductos()
        {
            return await _context.KCProductos.ToListAsync();
        }
    }
}
