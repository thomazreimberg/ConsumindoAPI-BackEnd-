using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API.Business
{
    public class FilmeBusiness
    {
        Database.FilmeDatabase FilmeDatabase = new Database.FilmeDatabase(); 
        public void Inserir(Models.TbFilme filme)
        {
            if(string.IsNullOrWhiteSpace(filme.DsCategoria))
                throw new ArgumentException("Informe a categoria");

            if(string.IsNullOrWhiteSpace(filme.NmFilme))
                throw new ArgumentException("Informe o nome do filme");

            FilmeDatabase.Inserir(filme);
        }

        public List<Models.TbFilme> ConsultarTodos()
        {
            return FilmeDatabase.ConsultarTodos();
        }

        public List<Models.TbFilme> ConsultarCategoria(string categoria)
        {
            return FilmeDatabase.ConsultarCategoria(categoria);
        }

        public void Alterar(Models.TbFilme filme)
        {
            if(string.IsNullOrWhiteSpace(filme.DsCategoria))
                throw new ArgumentException("Informe a categoria");

            if(string.IsNullOrWhiteSpace(filme.NmFilme))
                throw new ArgumentException("Informe o nome do filme");

            FilmeDatabase.Alterar(filme);
        }

        public void Remover(int id)
        {
            if(id == 0)
                throw new ArgumentException("Informe um id");
            FilmeDatabase.Remover(id);
        }
    }
}