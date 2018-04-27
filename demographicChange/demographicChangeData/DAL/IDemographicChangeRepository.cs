using demographicChangeEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicChangeData.DAL
{
    public interface IDemographicChangeRepository
    {
        void InsertData(DemographicChangeEntity demographicChange);
        List<DemographicChangeEntity> GetAllDemographicChangeData();
        void Save();
    }
}
