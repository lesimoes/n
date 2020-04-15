using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aula02.Models;

namespace Aula02.Controllers
{
    public class FilmesController : Controller
    {

        public ActionResult Random()
        {
            var filme = new Filme() { Name = "Avatar" };
            var clientes = new List<Cliente>
            {
                new Cliente { Name = "Winglerson" },
                new Cliente { Name = "Carla" }
            };

            var viewModel = new RandomFilmeViewModel
            {
                Filme = filme,
                Clientes = clientes
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id, int genero)
        {

            return Content("id=" + id + " genero= " + genero);
        }

        public ActionResult PorData(int ano, int mes)
        {
            return Content(ano + "/" + mes);
        }

        [Route("filmes/ano/{ano}/genero/{genero}")]
        public ActionResult PorAnoGenero(int ano, string genero)
        {
            return Content("Ano: " + ano + " Genero: " + genero);
        }

        [Route("diretor/{diretor}")]
        public ActionResult PorDiretor(string diretor)
        {
            return Content("Diretor: " + diretor);
        }

        public ActionResult Index()
        {
            return View ();
        }
    }
}
