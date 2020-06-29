using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninjaficator2020.Model
{
    public class NinjaName : IName
    {
        public string PersonName { get; set; }
        public string OrganisationAdjective { get; set; }
        public string OrganisationName { get; set; }
    }
}
