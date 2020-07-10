using Ninjaficator2020.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninjaficator2020.BLL.Interface
{
    public interface INameGenerator
    {
        /// <summary>
        /// Generate a ninja name from a string.
        /// </summary>
        /// <param name="techName">source string</param>
        /// <returns>Ninja name</returns>
        TreatmentResult<string> GenerateNinjaName(string techName);
    }
}
