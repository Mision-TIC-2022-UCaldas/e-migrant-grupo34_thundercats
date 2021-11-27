using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Migrantes.App.Persistencia;
using Migrantes.App.Dominio;

namespace Migrantes.App.Presentacion.Pages
{ 
    public class VistaMigranteModel : PageModel
    {
        private readonly IRepositorioMigrante _Repomigrante;
        public Migrante migrante {get; set;}

        public int idverificacion {get; set;}

       
        public VistaMigranteModel( IRepositorioMigrante _Repomigrante)
        {
            this._Repomigrante=_Repomigrante;
            this.idverificacion=idverificacion;
        }
        public void OnGet()
        {
           
        
        }
        }
    }
