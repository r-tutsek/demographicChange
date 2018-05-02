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
        private readonly IDemographicChangeByEthnicGroupsRepository _demographicChangeByEthnicGroupsRepository;
        private readonly IDemographicChangeService _demographicChangeService;

        public DemographicChangeApiController(IDemographicChangeRepository demographicChangeRepository, IDemographicChangeByEthnicGroupsRepository demographicChangeByEthnicGroupsRepository, IDemographicChangeService demographicChangeService)
        {
            this._demographicChangeRepository = demographicChangeRepository;
            this._demographicChangeByEthnicGroupsRepository = demographicChangeByEthnicGroupsRepository;
            this._demographicChangeService = demographicChangeService;
        }

        [HttpPost]
        public IHttpActionResult GetData(DemographicChangeRequest searchRequest)
        {
            var assembly = Assembly.Load(searchRequest.NamespaceName);
            var type = assembly.GetType(searchRequest.NamespaceName + "." + searchRequest.ClassName);
            
            var constructor = type.GetConstructor(new Type[] { typeof(DemographicChangeRepository), typeof(DemographicChangeByEthnicGroupsRepository) });
            var classObject = constructor.Invoke(new Object[] { this._demographicChangeRepository, this._demographicChangeByEthnicGroupsRepository });

            var method = type.GetMethod(searchRequest.MethodName);
            var demographicChangeData = method.Invoke(classObject, null);
           
            return Ok(demographicChangeData);
        }
    }
}
