using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication6.Scripts;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string roof_type = "1";
            double house_lenght = 5;
            double house_width = 5;
            double degree = 5;
            double cover = 1;
            string profnastil = "1";
            string barrier = "50";
            string insulation = "800";
            Calс calс = new Calс();
          string text =  calс.Сalculation(roof_type, house_lenght, house_width, degree, cover, profnastil, barrier, insulation);
            Assert.AreEqual(text, "1");

        }
    }
}
