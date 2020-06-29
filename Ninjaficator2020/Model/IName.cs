using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninjaficator2020.Model
{
    public interface IName
    {
        string PersonName { get; set; }

        string OrganisationAdjective { get; set; }

        string OrganisationName { get; set; }
    }
}
