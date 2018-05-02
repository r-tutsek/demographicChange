using DemographicChangeData.DAL;
using demographicChangeEntity.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demographicChangeService
{
    public class DemographicChangeService : IDemographicChangeService
    {
        private readonly IDemographicChangeRepository _demographicChangeRepository;
        private readonly IDemographicChangeByEthnicGroupsRepository _demographicChangeByEthnicityRepository;

        public DemographicChangeService(IDemographicChangeRepository demographicChangeRepository, IDemographicChangeByEthnicGroupsRepository demographicChangeByEtnicityRepository)
        {
            this._demographicChangeRepository = demographicChangeRepository;
            this._demographicChangeByEthnicityRepository = demographicChangeByEtnicityRepository;
        }
        
        public List<DemographicChangeEntity> GetTotalPopulation()
        {
            return this._demographicChangeRepository.GetAllDemographicChangeData();
        }

        public List<DemographicChangeByEthnicGroupsEntity> GetEthnicGroupsPopulation()
        {
            return this._demographicChangeByEthnicityRepository.GetDemographicChangeByEthnicGroupsData();
        }
    }
}
