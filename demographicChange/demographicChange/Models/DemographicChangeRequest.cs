using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demographicChange.Models
{
    public class DemographicChangeRequest
    {
        public string CountryName { get; set; }
        public string NamespaceName { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
    }
}