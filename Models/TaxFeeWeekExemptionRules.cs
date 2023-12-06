using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Congestion.enums;

namespace Congestion.Domain
{
    public class TaxFeeWeekExemptionRules
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public WeekDays WeekDay { get; set; }
    }
}