using EscolaApi.Data;
using EscolaApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EscolaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public ProfessoresController (AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Professor>>>GetProfessores()
        {
            return await _context.Professores.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> CriarProfessor(Professor professor)
        {
            _context.Professores.Add(professor);
            await _context.SaveChangesAsync();
            return Ok("Professor Cadastrado com sucesso!!!");
        }
    }
}
