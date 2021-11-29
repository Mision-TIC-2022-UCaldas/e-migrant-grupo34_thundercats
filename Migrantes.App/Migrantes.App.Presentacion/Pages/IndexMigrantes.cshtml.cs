using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Migrantes.App.Presentacion.Pages
{
    public class IndexMigrantesModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexMigrantesModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
