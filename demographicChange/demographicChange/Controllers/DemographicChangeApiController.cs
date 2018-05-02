using demographicChange.Models;
using DemographicChangeData.DAL;
using demographicChangeEntity.Entity;
using demographicChangeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;

namespace demographicChange.Controllers
{
    public class DemographicChangeApiController : ApiController
    {
        private readonly IDemographicChangeRepository _demographicChangeRepository;
        private readonly IDemographicChangeService _demographicChangeService;

        public DemographicChangeApiController(IDemographicChangeRepository demographicChangeRepository, IDemographicChangeService demographicChangeService)
        {
            this._demographicChangeRepository = demographicChangeRepository;
            this._demographicChangeService = demographicChangeService;
        }

        [HttpPost]
        public IHttpActionResult GetDemographicChangeData(DemographicChangeRequest searchRequest)
        {
            var assembly = Assembly.Load(searchRequest.NamespaceName);
            var type = assembly.GetType(searchRequest.NamespaceName + "." + searchRequest.ClassName);
            
            var constructor = type.GetConstructor(new Type[] { typeof(DemographicChangeRepository) });
            var classObject = constructor.Invoke(new Object[] { this._demographicChangeRepository });

            var method = type.GetMethod(searchRequest.MethodName);
            var demographicChangeData = method.Invoke(classObject, null);
           
            return Ok(demographicChangeData);
        }

        /*public List<DemographicChangeEntity> GetMockData()
        {
            List<DemographicChangeEntity> demographicChangeData = new List<DemographicChangeEntity>()
            {
                new DemographicChangeEntity() { Year = 1989, PopulationCount = 23161458 },
                new DemographicChangeEntity() { Year = 1990, PopulationCount = 23201835 },
                new DemographicChangeEntity() { Year = 1991, PopulationCount = 23001155 },
                new DemographicChangeEntity() { Year = 1992, PopulationCount = 22794284 },
                new DemographicChangeEntity() { Year = 1993, PopulationCount = 22763280 },
                new DemographicChangeEntity() { Year = 1994, PopulationCount = 22730211 },
                new DemographicChangeEntity() { Year = 1995, PopulationCount = 22684270 },
                new DemographicChangeEntity() { Year = 1996, PopulationCount = 22619004 },
                new DemographicChangeEntity() { Year = 1997, PopulationCount = 22553978 },
                new DemographicChangeEntity() { Year = 1998, PopulationCount = 22507344 },
                new DemographicChangeEntity() { Year = 1999, PopulationCount = 22472040 },
                new DemographicChangeEntity() { Year = 2000, PopulationCount = 22442971 },
                new DemographicChangeEntity() { Year = 2001, PopulationCount = 22131970 },
                new DemographicChangeEntity() { Year = 2002, PopulationCount = 21730496 },
                new DemographicChangeEntity() { Year = 2003, PopulationCount = 21574326 },
                new DemographicChangeEntity() { Year = 2004, PopulationCount = 21451748 },
                new DemographicChangeEntity() { Year = 2005, PopulationCount = 21319685 },
                new DemographicChangeEntity() { Year = 2006, PopulationCount = 21193760 },
                new DemographicChangeEntity() { Year = 2007, PopulationCount = 20882982 },
                new DemographicChangeEntity() { Year = 2008, PopulationCount = 20537875 },
                new DemographicChangeEntity() { Year = 2009, PopulationCount = 20367487 },
                new DemographicChangeEntity() { Year = 2010, PopulationCount = 20246871 },
                new DemographicChangeEntity() { Year = 2011, PopulationCount = 20147528 },
                new DemographicChangeEntity() { Year = 2012, PopulationCount = 20058035 },
                new DemographicChangeEntity() { Year = 2013, PopulationCount = 19983693 },
                new DemographicChangeEntity() { Year = 2014, PopulationCount = 19908979 },
                new DemographicChangeEntity() { Year = 2015, PopulationCount = 19815481 },
                new DemographicChangeEntity() { Year = 2016, PopulationCount = 19699312 },
                new DemographicChangeEntity() { Year = 2017, PopulationCount = 19120437 },
                new DemographicChangeEntity() { Year = 2018, PopulationCount = 21485519 }
            };
            return demographicChangeData;
        }*/
    }
}
