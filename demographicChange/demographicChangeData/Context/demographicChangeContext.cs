using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demographicChangeEntity.Entity;

namespace DemographicChangeData.Context
{
    public class DemographicChangeContext : DbContext
    {
        public DbSet<DemographicChangeEntity> ChangeContext { get; set; }
        public DbSet<DemographicChangeByEthnicGroupsEntity> ChangeByEthnicGroupsContext { get; set; }
    }
}
