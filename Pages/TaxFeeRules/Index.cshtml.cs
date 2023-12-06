using Congestion.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Congestion.Pages
{
    public class TaxFeeIndexRulesModel : PageModel
    {
        private readonly DataContext _context;

        public TaxFeeIndexRulesModel(DataContext context)
        {
            _context = context;
        }

        public IList<Congestion.Domain.TaxFeeRules> TaxFeeRules { get; set; }

        public async Task OnGetAsync()
        {
            TaxFeeRules = await _context.TaxFees.ToListAsync();
        }
         public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var TaxFeeRule = await _context.TaxFees.FindAsync(id);

            if (TaxFeeRule != null)
            {
                _context.TaxFees.Remove(TaxFeeRule);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}