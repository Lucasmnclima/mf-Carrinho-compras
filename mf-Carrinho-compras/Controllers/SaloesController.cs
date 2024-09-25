using CarrinhoDeComprasGestaoSalao.Models;
using mf_Carrinho_compras.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace mf_Carrinho_compras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaloesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SaloesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Saloes.ToListAsync();

            return Ok(model);
        }

        public AppDbContext Get_context()
        {
            return _context;
        }

        [HttpPost]
        public async Task<ActionResult> Create(Salao model, AppDbContext _context)
        {
            if(model.Nome == null)
            {
                return BadRequest(new { message = "Por favor, verifique os dados e tente novamente." });
            }

            _context.Saloes.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.Saloes
                .FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) NotFound();

            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Salao model)
        {
            if (id != model.Id) return BadRequest();
            var modeloDb = await _context.Saloes.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if(modeloDb == null) return NotFound();

            _context.Saloes.Update(model);
            await _context.SaveChangesAsync();

            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var model = await _context.Saloes.FindAsync(id);

            if (model == null) NotFound();

            _context.Saloes.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}
