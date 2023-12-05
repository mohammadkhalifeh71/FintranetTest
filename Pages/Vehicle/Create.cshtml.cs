using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class CreateVehicleModel : PageModel
    {
        private readonly DataContext _context;

        public CreateVehicleModel(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> VehicleTypes { get; set; }

        [BindProperty]
        public Congestion.Domain.Vehicle Vehicle { get; set; }

        public void OnGet()
        {
            VehicleTypes = _context.VehicleType.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Title });

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vehicles.Add(Vehicle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}