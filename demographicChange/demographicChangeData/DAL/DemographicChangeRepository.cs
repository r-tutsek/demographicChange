using DemographicChangeData.Context;
using demographicChangeEntity.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemographicChangeData.DAL
{
    public class DemographicChangeRepository : IDemographicChangeRepository, IDisposable
    {
        private DemographicChangeContext context;
        private bool disposed = false;

        public DemographicChangeRepository()
        {
            this.context = new DemographicChangeContext();
        }

        public void InsertData(DemographicChangeEntity demographicChange)
        {
            this.context.ChangeContext.Add(demographicChange);
        }

        public List<DemographicChangeEntity> GetAllDemographicChangeData()
        {
            return this.context.ChangeContext.OrderBy(x => x.Year).ToList<DemographicChangeEntity>();
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
