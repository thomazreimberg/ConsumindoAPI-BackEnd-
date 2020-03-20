using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        Business.FilmeBusiness FilmeBusiness = new Business.FilmeBusiness(); 

        [HttpPost]
        public void Inserir(Models.TbFilme filme)
        {
            FilmeBusiness.Inserir(filme);
        }

        [HttpPut]
        public void Alterar(Models.TbFilme filme)
        {
            FilmeBusiness.Alterar(filme);
        }

        [HttpDelete("{id}")]
        public void Remover(int id)         
        {
            FilmeBusiness.Remover(id);
        }

        [HttpGet("ConsultarTodos")]
        public List<Models.TbFilme> ConsultarTodos()
        {
            return FilmeBusiness.ConsultarTodos();
        }

        [HttpGet("ConsultarCategoria/{categoria}")]
        public List<Models.TbFilme> ConsultarCategoria(string categoria)
        {
            return FilmeBusiness.ConsultarCategoria(categoria);
        }
    }
}