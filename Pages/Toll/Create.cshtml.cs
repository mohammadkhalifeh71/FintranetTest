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
    public class CreateTollModel : PageModel
    {
        private readonly ILogger<CreateTollModel> _logger;
        private readonly DataContext _context;
          public IEnumerable<SelectListItem> VehicleTypes { get; set; }
        public CreateTollModel(ILogger<CreateTollModel> logger, DataContext dataContext)
        {
            _logger = logger;
            _context = dataContext;
        }
        public void OnGet()
        {
            VehicleTypes=_context.VehicleType.Select(x=>new SelectListItem{Value=x.Id.ToString(),Text=x.Title});
        }
    }
}