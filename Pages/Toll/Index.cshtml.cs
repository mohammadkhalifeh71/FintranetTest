using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congestion.Domain;
using Congestion.enums;
using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Congestion.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class IndexTollModel : PageModel
    {
        private readonly DataContext _context;
          public List<Congestion.Domain.Toll> Tolls { get; set; }
        public IndexTollModel(ILogger<CreateTollModel> logger, DataContext dataContext)
        {
            _context = dataContext;
        }
        public void OnGet()
        {
            Tolls=_context.Tolls.ToList();
        }
    }
}