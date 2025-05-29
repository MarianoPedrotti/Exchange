using Exchange.Data;
using Exchange.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exchange.Controllers
{
    [ApiController]
    [Route("api/controller")]    
    public class MonedasController : Controller
    {
        private readonly AppDbContext _context;
        public  MonedasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Get:api/Monedas
        [HttpGet]
        public async Task<IActionResult> obtenerMonedas()
        {

        }
    }
}
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//[ApiController]
//[Route("api/[controller]")]
//public class MonedasController : ControllerBase
//{
//    private readonly AppDbContext _context;

//    public MonedasController(AppDbContext context)
//    {
//        _context = context;
//    }

//    // GET: api/monedas
//    [HttpGet]
//    public async Task<IActionResult> GetMonedas()
//    {
//        var monedas = await _context.Monedas.ToListAsync();
//        return Ok(monedas);
//    }

//    // POST: api/monedas
//    [HttpPost]
//    public async Task<IActionResult> CrearMoneda([FromBody] Moneda moneda)
//    {
//        if (!ModelState.IsValid)
//            return BadRequest(ModelState);

//        _context.Monedas.Add(moneda);
//        await _context.SaveChangesAsync();

//        return Ok(moneda);
//    }
//}
