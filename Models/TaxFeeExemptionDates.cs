using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Congestion.enums;

namespace Congestion.Domain
{
    public class TaxFeeExemptionDates
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}