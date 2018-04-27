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

        public DemographicChangeService(IDemographicChangeRepository demographicChangeRepository)
        {
            this._demographicChangeRepository = demographicChangeRepository;
        }

        public void AddMockData(List<DemographicChangeEntity> demographicChange)
        {
            foreach (var demoChange in demographicChange)
            {
                var demographicChangeEntity = new DemographicChangeEntity()
                {
                    Year = demoChange.Year,
                    PopulationCount = demoChange.PopulationCount
                };
                this._demographicChangeRepository.InsertData(demographicChangeEntity);
                this._demographicChangeRepository.Save();
            }
        }

        public List<DemographicChangeEntity> GetChangeData()
        {
            return this._demographicChangeRepository.GetAllDemographicChangeData();
        }
    }
}
