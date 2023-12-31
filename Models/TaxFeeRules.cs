using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Congestion.Domain
{
    public class TaxFeeRules
    {
        public int Id { get; set; }
        public List<TaxFeeWeekExemptionRules> TaxFeeWeekExemptionRules { get; set; }
        public List<TaxFeeTimeRules> TaxFeeTimeRules { get; set; }
        public List<TaxFeeExemptionDates> TaxFeeExemptionDates { get; set; }
        public string Title { get; set; }
    }
}