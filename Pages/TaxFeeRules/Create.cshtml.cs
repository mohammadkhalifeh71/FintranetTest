using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class CreateTaxFeeRuleModel : PageModel
    {
        private readonly DataContext _context;

        public CreateTaxFeeRuleModel(DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Congestion.Domain.TaxFeeRules TaxFeeRule { get; set; }

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

            _context.TaxFees.Add(TaxFeeRule);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}