using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTestBil()
        {
            //Arrange//
            Bil Bil = new Bil();
            int Pris = Bil.Pris();

            //Acts//
            Assert.AreEqual(240, Pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            //Arrange/
            Bil Bil = new Bil();
            string Køretøj = Bil.Køretøj();

            //Acts//
            Assert.AreEqual("Bil", Køretøj);

        }
    }
}