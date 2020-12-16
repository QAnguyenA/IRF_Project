using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRF_Beadando_bmt3q9.Kontroller;
using NUnit.Framework;

namespace UnitTestProjectBeadandó
{
    public class RendKontrollerTest
    {
        [
            
             Test,
             TestCase("abcd1234", false),
             TestCase("06201234567", false),
             TestCase("Kamu./5", false),
             TestCase("Péter", true)
        ]
        public void TestValidateNev(string nev, bool expectedResult)
        {
            var rendkontroller = new RendelesKontroller();

            var actualResult = rendkontroller.Validatenev(nev);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
