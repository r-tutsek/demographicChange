using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace demographicChangeEntity.Entity
{
    public class DemographicChangeEntity
    {
        [Key]
        public double PopulationCount { get; set; }
        public int Year { get; set; }        
    }
}
