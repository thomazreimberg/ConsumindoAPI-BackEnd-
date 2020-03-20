using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace API.Database
{
    public class FilmeDatabase
    {
        Models.testevivenciaContext db = new Models.testevivenciaContext();
        public void Inserir(Models.TbFilme filme)
        {
            db.TbFilme.Add(filme);
            db.SaveChanges();
        }

        public List<Models.TbFilme> ConsultarTodos()
        {
            return db.TbFilme.ToList();
        }

        public List<Models.TbFilme> ConsultarCategoria(string categoria)
        {
            return db.TbFilme.Where(x => x.DsCategoria.Contains(categoria)).ToList();
        }

        public void Alterar(Models.TbFilme filme)
        {
            Models.TbFilme alterar = db.TbFilme.First(x => x.IdFilme == filme.IdFilme);
            alterar.NmFilme = filme.NmFilme;
            alterar.DsCategoria = filme.DsCategoria;
            alterar.DtLancamento = filme.DtLancamento;

            db.SaveChanges();
        }

        public void Remover(int id)
        {
            Models.TbFilme remover = db.TbFilme.First(x => x.IdFilme == id);
            db.Remove(remover);

            db.SaveChanges();
        }
    }
}