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
        public DateTime FromDate { get; set; }
        public DateTime FromTo { get; set; }
        public string Price { get; set; }
    }
}