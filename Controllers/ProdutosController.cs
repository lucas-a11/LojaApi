using LojaApi.Data;
using LojaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace LojaApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        private readonly AppDataContext _context;

        public ProdutosController(AppDataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            var produtos = _context.Produtos.ToList();
            if (produtos == null || !produtos.Any())
            {
                return Enumerable.Empty<Produto>();
            }
            return produtos;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            if (produto == null)
            {
                return NotFound();
            }
            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto == null)
            {
                return BadRequest("Produto não pode ser nulo.");
            }

            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = produto.ProdutoId }, produto);
        }

        [HttpPut("{id:int}")]

        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId) { return BadRequest(); }

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);

        }
    }
}
