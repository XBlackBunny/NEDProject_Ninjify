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
            var nameGen = new NameGenerator();

            var ninjaName = nameGen.GenerateNinjaName("Pascal");

            Assert.IsNotNull(ninjaName);
        }

        [TestMethod()]
        public void GenerateNinjaName_SameTechSameName()
        {
            var nameGen = new NameGenerator();

            var ninjaName1 = nameGen.GenerateNinjaName("Python");
            var ninjaName2 = nameGen.GenerateNinjaName("Python");

            Assert.AreEqual(ninjaName1.Result,ninjaName2.Result);
        }

        [TestMethod()]
        public void GenerateNinjaName_DifferentTechDifferentName()
        {
            var nameGen = new NameGenerator();

            var ninjaName1 = nameGen.GenerateNinjaName("Python");
            var ninjaName2 = nameGen.GenerateNinjaName("Html");

            Assert.AreNotEqual(ninjaName1.Result, ninjaName2.Result);
        }

        [TestMethod()]
        public void GenerateNinjaName_SourceTooShort()
        {
            var nameGen = new NameGenerator();

            var ninjaName = nameGen.GenerateNinjaName("q");

            Assert.IsTrue(ninjaName.HasError);
            Assert.AreEqual(ninjaName.Result, default);
            Assert.IsNull(ninjaName.Exception);
        }

        [TestMethod()]
        public void GenerateNinjaName_SourceIsToLong()
        {
            var nameGen = new NameGenerator();

            var ninjaName = nameGen.GenerateNinjaName("fdsaaaaaaafdafsfsdfsdfsdfsdafsdq");

            Assert.IsTrue(ninjaName.HasError);
            Assert.AreEqual(ninjaName.Result, default);
            Assert.IsNull(ninjaName.Exception);
        }

        [TestMethod()]
        public void GenerateNinjaName_KonamiCode()
        {
            var nameGen = new NameGenerator();

            var ninjaName = nameGen.GenerateNinjaName("↑↑↓↓←→←→ba");

            Assert.IsTrue(ninjaName.HasError);
            Assert.AreEqual(ninjaName.Result, "");
            Assert.IsNull(ninjaName.Exception);
        }
    }
}