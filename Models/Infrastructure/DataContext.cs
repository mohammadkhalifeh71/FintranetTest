using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congestion.Domain;
using Microsoft.EntityFrameworkCore;

namespace Congestion.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<TaxFeeRules> TaxFees { get; set; }
        public DbSet<TaxFeeExemptionDates> TaxFeeExemptionDates { get; set; }
        public DbSet<TaxFeeTimeRules> TaxFeeTimeRules { get; set; }
        public DbSet<TaxFeeWeekExemptionRules> TaxFeeWeekExemptionRules { get; set; }
        public DbSet<Toll> Tolls { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }



    }
}