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

        [HttpGet]
        public IHttpActionResult GetTotalPopulationData()
        {
            return Ok(this._demographicChangeService.GetTotalPopulation());
        }

        [HttpGet]
        public IHttpActionResult GetEthnicGroupsPopulationData()
        {
            return Ok(this._demographicChangeService.GetEthnicGroupsPopulation());
        }
    }
}
