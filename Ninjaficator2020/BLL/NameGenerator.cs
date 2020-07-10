using Microsoft.AspNetCore.SignalR;
using Ninjaficator2020.Data;
using Ninjaficator2020.BLL.Interface;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninjaficator2020.Model;

namespace Ninjaficator2020.BLL
{
    public class NameGenerator : INameGenerator
    {
        public NameGenerator()
        {
        }

        public TreatmentResult<string> GenerateNinjaName(string techName)
        {
            if (techName.Length > 24 || techName.Length < 2 || string.IsNullOrWhiteSpace(techName))
                return new TreatmentResult<string>("Source string has an invalid length: should be between 2 and 24.", null);

            long[] partsIndex = StringToIntHelper.GetIntsFromString(techName);

            if (partsIndex.All(index => index == -1))
            {
                var name = "4173686c65792c204d656d626572206f6620746865204c6f79616c747920746f20796f7520636c616e";
                var nameBytes = Enumerable.Range(0, name.Length)
                                 .Where(x => x % 2 == 0)
                                 .Select(x => Convert.ToByte(name.Substring(x, 2), 16))
                                 .ToArray();

                var result = new TreatmentResult<string>(System.Text.Encoding.Default.GetString(nameBytes));
                result.ErrorMessage = "420";
                return result;
            }
            

            var personNameIndex = partsIndex[0] % NinjaNameData.PersonName.Length;
            var orgAdjIndex = partsIndex[1] % NinjaNameData.OrganisationAdjective.Length;
            var orgNameIndex = partsIndex[2] % NinjaNameData.OrganisationName.Length;

            var ninjaTitleFormat = "{0}, Member of the {1} {2} clan.";

            return new TreatmentResult<string>(string.Format(ninjaTitleFormat, 
                NinjaNameData.PersonName[personNameIndex], 
                NinjaNameData.OrganisationAdjective[orgAdjIndex], 
                NinjaNameData.OrganisationName[orgNameIndex]));
        }

       
    }
}
