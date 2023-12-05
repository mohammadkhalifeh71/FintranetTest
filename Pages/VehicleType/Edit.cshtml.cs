using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class EditVehicleTypeModel : PageModel
    {
        private readonly DataContext _context;

        public EditVehicleTypeModel(DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Congestion.Domain.VehicleType VehicleType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VehicleType = await _context.VehicleType.FirstOrDefaultAsync(m => m.Id == id);

            if (VehicleType == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VehicleType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.VehicleType.Any(e => e.Id == VehicleType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
    }
}