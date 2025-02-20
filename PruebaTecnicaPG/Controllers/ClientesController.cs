using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnicaPG.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaPG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodom para obtener clientes con linq ef
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("ef")]
        [Produces("application/json")]
        public async Task<IActionResult> GetClientesEF(int page = 1, int pageSize = 10)
        {
            var clientes = await _context.Clientes
                .OrderBy(c => c.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return Ok(clientes);
        }

        /// <summary>
        /// Metodo para obtener clientes mediante SP (Simulado)
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("sp")]
        [Produces("application/json")]
        public async Task<IActionResult> GetClientesSP(int page = 1, int pageSize = 10)
        {
            // En un entorno productivo, este metodo usaria un stored procedure real,
            // utilizando una llamada similar a la siguiente:

            //var clientes = await _context.Clientes
            //    .FromSqlRaw("EXEC GetClientesPaginados @Page={0}, @PageSize={1}", page, pageSize)
            //    .ToListAsync();

            // Utilice EF InMemory para pruebas, por ende simule la funcionalidad
            // del SP realizando la paginación mediante LINQ
            // que es similar al metodo de ef

            //Tambien se podria estrcuturar en capas para usar mediante una clase command mediante Inyeccion de dependecia
            //que utilice el SqlConnection , SqlCommand CommandType.StoredProcedure

            var clientes = await _context.Clientes
                .OrderBy(c => c.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(clientes);
        }
    }
}

