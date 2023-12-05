using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class IndexVehicleModel : PageModel
    {
        private readonly DataContext _context;

        public IndexVehicleModel(DataContext context)
        {
            _context = context;
        }

        public IList<Congestion.Domain.Vehicle> Vehicles { get; set; }

        public async Task OnGetAsync()
        {
            Vehicles = await _context.Vehicles.Select().ToListAsync();
        
        }
         public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var VehicleById = await _context.Vehicles.FindAsync(id);

            if (VehicleById != null)
            {
                _context.Vehicles.Remove(VehicleById);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}