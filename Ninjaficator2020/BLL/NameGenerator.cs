using Microsoft.AspNetCore.SignalR;
using Ninjaficator2020.Data;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninjaficator2020.BLL
{
    public static class NameGenerator
    {
        public static string GenerateNinjaName(string techName)
        {
            long[] partsIndex = StringToIntHelper.GetIntsFromString(techName);

            var personNameIndex = partsIndex[0] % NinjaNameData.PersonName.Length;
            var orgAdjIndex = partsIndex[1] % NinjaNameData.OrganisationAdjective.Length;
            var orgNameIndex = partsIndex[2] % NinjaNameData.OrganisationName.Length;

            var ninjaTitleFormat = "{0}, Member of the {1} {2} clan.";

            return string.Format(ninjaTitleFormat, 
                NinjaNameData.PersonName[personNameIndex], 
                NinjaNameData.OrganisationAdjective[orgAdjIndex], 
                NinjaNameData.OrganisationName[orgNameIndex]);
        }

       
    }
}
