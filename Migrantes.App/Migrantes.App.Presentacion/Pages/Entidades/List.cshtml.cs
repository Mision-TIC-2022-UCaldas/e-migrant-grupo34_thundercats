using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion.Pages.Entidades
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioEntidad _repoEntidad;

        public string Ciudad {get;set;}
        public int Nit {get;set;}

        public Migrante migrante {get; set;}
        
        public IEnumerable<Entidad> Entities { get; set; }
        public IEnumerable<Entidad> Entities1 { get; set; }

        public ListModel(IRepositorioEntidad repoEntidad)
        {
            this._repoEntidad = repoEntidad;
        }
        public void OnGet(string Ciudad, int Nit)
        {


            Entities = _repoEntidad.GetAllByCiudad(Ciudad);

            Entities1 = _repoEntidad.GetAllByNit(Nit);


        }
        }
    }
