﻿
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[Ccontroller]")]

    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
        }
    }
}