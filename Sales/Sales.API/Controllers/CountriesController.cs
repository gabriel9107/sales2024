
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sales.API.Data;
using Sales.Shared.Entities;

namespace Sales.API.Controllers
{

    [ApiController]
    [Route("/api/countries")]
    public class CountriesController : Controller
    {
        private readonly DataContext _context;
        public CountriesController(DataContext context)
        {
        _context = context; 
        
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync(Country country)
        {
            _context.Add(country);
            _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {

            return Ok( await _context.countries.ToListAsync());
        }
    }



}
