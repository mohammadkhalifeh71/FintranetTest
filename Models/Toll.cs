using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Congestion.enums;

namespace Congestion.Domain
{
    public class Toll
    {
        public int Id { get; set; }
        [ForeignKey("VehicleId")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        [ForeignKey("TaxFeeId")]
        public int TaxFeeId { get; set; }
        public TaxFeeRules TaxFee { get; set; }
        public TollState TollState { get; set; }
        public DateTime Date { get; set; }

    }
}