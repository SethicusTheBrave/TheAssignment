﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringAssignment;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RyanUnitTest()
        {
            DateTime dt;
            BusinessMetaLayer instance = BusinessMetaLayer.instance();
            Staff s = new Staff();
            dt = DateTime.Now.AddYears(-21);
            s.getDOB = dt;
            s.getpassword = instance.encrypt("SuperDuperPassword1");
            s.getFirstName = "Nigel";
            s.getLastName = "Edwards";
            s.getEmail = "NigelEdwards@gmail.com";
            s.getPostcode = "WC2H 8AG";
            s.getAddress = "13 St Giles High St, London";
            s.getStaffID = 10;
            s.getType = "Doctor";
            Assert.AreEqual(instance.encrypt("SuperDuperPassword1"), s.getpassword);
            Assert.AreEqual("Nigel", s.getFirstName);
            Assert.AreEqual("Edwards", s.getLastName);
            Assert.AreEqual("NigelEdwards@gmail.com", s.getEmail);
            Assert.AreEqual(dt.ToString(), s.getDOB.ToString());
            Assert.AreEqual("WC2H 8AG", s.getPostcode);
            Assert.AreEqual("13 St Giles High St, London", s.getAddress);
            Assert.AreEqual(10, s.getStaffID);
            Assert.AreEqual("Doctor", s.getType);

            Patient p = new Patient();
            p.getPatientID = 25;
            p.getFirstName = "Dan";
            p.getLastName = "Purdy";
            dt = DateTime.Now.AddYears(-21);
            p.getDOB = dt;
            p.getEmail = "Dan.Purdy@live.co.uk";
            p.getCountry = "England";
            p.getMedicalHistory = "HE IS FINE";
            p.getPhoneNumber = "999";
            p.getPresent = true;
            p.getAddress = "College of West Anglia";
            p.getPostcode = "PE13 2JE";

            Assert.AreEqual(25, p.getPatientID);
            Assert.AreEqual("Dan", p.getFirstName);
            Assert.AreEqual("Purdy", p.getLastName);
            Assert.AreEqual(dt.ToString(), p.getDOB.ToString());
            Assert.AreEqual("Dan.Purdy@live.co.uk", p.getEmail);
            Assert.AreEqual("England", p.getCountry);
            Assert.AreEqual("HE IS FINE", p.getMedicalHistory);
            Assert.AreEqual("999", p.getPhoneNumber);
            Assert.AreEqual(true, p.getPresent);
            Assert.AreEqual("College of West Anglia", p.getAddress);
            Assert.AreEqual("PE13 2J3", p.getPostcode);
        }
    }
}
