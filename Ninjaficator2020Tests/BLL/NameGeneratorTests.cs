using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninjaficator2020.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjaficator2020.BLL.Tests
{
    [TestClass()]
    public class NameGeneratorTests
    {
        [TestMethod()]
        public void GenerateNinjaNameTest()
        {
            var ninjaName = NameGenerator.GenerateNinjaName("Pascal");

            Assert.IsNotNull(ninjaName);
        }

        [TestMethod()]
        public void GenerateNinjaName_SameTechSameName()
        {
            var ninjaName1 = NameGenerator.GenerateNinjaName("Python");
            var ninjaName2 = NameGenerator.GenerateNinjaName("Python");

            Assert.AreEqual(ninjaName1,ninjaName2);
        }

        [TestMethod()]
        public void GenerateNinjaName_DifferentTechDifferentName()
        {
            var ninjaName1 = NameGenerator.GenerateNinjaName("Python");
            var ninjaName2 = NameGenerator.GenerateNinjaName("Html");

            Assert.AreNotEqual(ninjaName1, ninjaName2);
        }
    }
}