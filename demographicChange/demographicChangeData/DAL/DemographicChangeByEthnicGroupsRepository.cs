using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemographicChangeData.Context;
using demographicChangeEntity.Entity;

namespace DemographicChangeData.DAL
{
    public class DemographicChangeByEthnicGroupsRepository : IDemographicChangeByEthnicGroupsRepository, IDisposable
    {
        private DemographicChangeContext context;
        private bool disposed = false;

        public DemographicChangeByEthnicGroupsRepository() {
            this.context = new DemographicChangeContext();
        }

        public List<DemographicChangeByEthnicGroupsEntity> GetDemographicChangeByEthnicGroupsData()
        {
            return this.context.ChangeByEthnicGroupsContext.ToList<DemographicChangeByEthnicGroupsEntity>();
        }

        public void InsertData(DemographicChangeByEthnicGroupsEntity demographicChangeByEtnicGroups)
        {
            this.context.ChangeByEthnicGroupsContext.Add(demographicChangeByEtnicGroups);
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
