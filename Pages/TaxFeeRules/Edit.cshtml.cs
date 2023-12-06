using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class EditTaxFeeRulesModel : PageModel
    {
        private readonly DataContext _context;

        public EditTaxFeeRulesModel(DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Congestion.Domain.TaxFeeRules TaxFeeRule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TaxFeeRule = await _context.TaxFees.FirstOrDefaultAsync(m => m.Id == id);

            if (TaxFeeRule == null)
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

            _context.Attach(TaxFeeRule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.TaxFees.Any(e => e.Id == TaxFeeRule.Id))
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