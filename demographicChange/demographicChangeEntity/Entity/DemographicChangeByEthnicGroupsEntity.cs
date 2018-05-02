using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demographicChangeEntity.Entity
{
    public class DemographicChangeByEthnicGroupsEntity
    {
        public int Id { get; set; }
        public double PopulationCount { get; set; }
        public int Year { get; set; }
        public string Ethnicity { get; set; }
    }
}
