
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        
        [HttpPost]        
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            if (!string.IsNullOrEmpty(filme.Titulo)) 
            {
                filmes.Add(filme);
                filme.mostrarInfo();

            }
            return Ok("Filme Includio com Sucesso");
            
        }

        [HttpGet]
        public IActionResult ListaFilme()
        {
            return Ok(filmes);
        }
    }
}
