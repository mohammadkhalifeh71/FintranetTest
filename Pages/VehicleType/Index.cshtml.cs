using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class VehicleTypeIndexModel : PageModel
    {
        private readonly DataContext _context;

        public VehicleTypeIndexModel(DataContext context)
        {
            _context = context;
        }

        public IList<Congestion.Domain.VehicleType> VehicleTypes { get; set; }

        public async Task OnGetAsync()
        {
            VehicleTypes = await _context.VehicleType.ToListAsync();
        }
         public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleType = await _context.VehicleType.FindAsync(id);

            if (vehicleType != null)
            {
                _context.VehicleType.Remove(vehicleType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}