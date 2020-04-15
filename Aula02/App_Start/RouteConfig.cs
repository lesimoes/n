using System.Web.Mvc;
using System.Web.Routing;

namespace Aula02
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                "FilmePorData",
                "filmes/data/{ano}/{mes}",
                new { controller = "Filmes", action = "PorData"}
                );

            routes.MapRoute(
                "FilmePorDiretor",
                "diretor/{diretor}",
                new { controller = "Filmes", action = "PorDiretor" }
                );

            //routes.MapRoute(
            //    "FilmePorAnoGenero",
            //    "filmes/ano/{ano}/genero/{genero}",
            //    new { controller = "Filmes", action = "PorAnoGenero"}
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
