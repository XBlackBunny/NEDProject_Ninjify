using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninjaficator2020.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ninjaficator2020.BLL.Tests
{
    [TestClass()]
    public class StringToIntHelperTests
    {
        [TestMethod()]
        public void GetIntsFromStringTest()
        {
            var testString = "Sass";

            var resultArray = StringToIntHelper.GetIntsFromString(testString);

            foreach (var resultInt in resultArray)
            {
                Assert.AreNotEqual(0, resultInt);
            }
        }

        [TestMethod()]
        public void GetIntsFromString_SameStringSameValue()
        {
            var testString1 = "Sass";
            var testString2 = "Sass";

            var resultArray1 = StringToIntHelper.GetIntsFromString(testString1);
            var resultArray2 = StringToIntHelper.GetIntsFromString(testString2);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(resultArray1[i], resultArray2[i]);
            }
        }

        [TestMethod()]
        public void GetIntsFromString_DifferentStringDifferentValue()
        {
            var testString1 = "Sass";
            var testString2 = "Html";

            var resultArray1 = StringToIntHelper.GetIntsFromString(testString1);
            var resultArray2 = StringToIntHelper.GetIntsFromString(testString2);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreNotEqual(resultArray1[i], resultArray2[i]);
            }
        }

        [TestMethod()]
        public void GetIntsFromString_NullReturnEmptyArray()
        {
            var resultArray = StringToIntHelper.GetIntsFromString(null);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(0,resultArray[i]);
            }
        }

        [TestMethod()]
        public void GetIntsFromString_EmptyArrayIfSourceTooSmall()
        {
            var resultArray = StringToIntHelper.GetIntsFromString(string.Empty);

            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(0, resultArray[i]);
            }
        }
    }
}