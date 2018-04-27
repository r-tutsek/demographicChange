using demographicChangeEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demographicChangeService
{
    public interface IDemographicChangeService
    {
        void AddMockData(List<DemographicChangeEntity> demographicChange);
        List<DemographicChangeEntity> GetChangeData();
    }
}
