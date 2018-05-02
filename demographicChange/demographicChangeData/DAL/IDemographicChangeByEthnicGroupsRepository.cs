using demographicChangeEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicChangeData.DAL
{
    public interface IDemographicChangeByEthnicGroupsRepository
    {
        void InsertData(DemographicChangeByEthnicGroupsEntity demographicChangeByEtnicGroups);
        List<DemographicChangeByEthnicGroupsEntity> GetDemographicChangeByEthnicGroupsData();
        void Save();
    }
}
