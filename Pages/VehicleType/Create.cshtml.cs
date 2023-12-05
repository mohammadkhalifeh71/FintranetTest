using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class CreateVehicleTypeModel : PageModel
    {
        private readonly DataContext _context;

        public CreateVehicleTypeModel(DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Congestion.Domain.VehicleType VehicleType { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.VehicleType.Add(VehicleType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}