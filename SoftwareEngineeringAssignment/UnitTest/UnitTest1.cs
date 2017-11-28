using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringAssignment;
using MySql;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RyanUnitTest();
        }
        private void RyanUnitTest()
        {
            BusinessMetaLayer instance = BusinessMetaLayer.instance();
            Staff s = new Staff();
            s.getAddress = "16 test lane";
            s.getCountry = "England";
            s.getDOB = DateTime.Now;
            s.getEmail = "superemail@hotmail.co.uk";
            s.getFirstName = "Nigel";
            s.getLastName = "Edwards";
            s.getpassword = instance.encrypt(instance.sanitize("AwesomeSauce"));
            
            
        }
    }
}
