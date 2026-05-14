using API_FECOM.Data;
using API_FECOM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_FECOM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProductosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Productos.ToList());
        }

        [HttpPost]
        public IActionResult Post(Producto producto)
        {
            _context.Productos.Add(producto);

            _context.SaveChanges();

            return Ok(producto);
        }
    }
}