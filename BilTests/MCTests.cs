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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTestMC()
        {
            //Arrange

            MC MC = new MC();
            int Pris = MC.Pris();

            //Action

            Assert.AreEqual(125, Pris);

        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //Arange

            MC MC = new MC();
            string Køretøj = MC.Køretøj();
            
            //Action

            Assert.AreEqual(Køretøj, "MC");
        }
    }
}