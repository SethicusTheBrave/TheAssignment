using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringAssignment;
using System.Collections.Generic;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RyanUnitTest()
        {
            //global Variables
            DateTime dt;
            BusinessMetaLayer instance = BusinessMetaLayer.instance();

            //staff testing
            Staff s = new Staff();
            dt = DateTime.Now.AddYears(-21);
            s.getDOB = dt;
            s.getpassword = instance.encrypt("password");
            s.getFirstName = "Nigel";
            s.getLastName = "Edwards";
            s.getEmail = "NigelEdwards@gmail.com";
            s.getPostcode = "WC2H 8AG";
            s.getAddress = "13 St Giles High St, London";
            s.getStaffID = 1;
            s.getType = "Doctor";
            Assert.AreEqual(instance.encrypt("password"), s.getpassword);
            Assert.AreEqual("Nigel", s.getFirstName);
            Assert.AreEqual("Edwards", s.getLastName);
            Assert.AreEqual("NigelEdwards@gmail.com", s.getEmail);
            Assert.AreEqual(dt.ToString(), s.getDOB.ToString());
            Assert.AreEqual("WC2H 8AG", s.getPostcode);
            Assert.AreEqual("13 St Giles High St, London", s.getAddress);
            Assert.AreEqual(1, s.getStaffID);
            Assert.AreEqual("Doctor", s.getType);

            //patient testing
            Patient p = new Patient();
            p.getPatientID = 2;
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
            Assert.AreEqual(2, p.getPatientID);
            Assert.AreEqual("Dan", p.getFirstName);
            Assert.AreEqual("Purdy", p.getLastName);
            Assert.AreEqual(dt.ToString(), p.getDOB.ToString());
            Assert.AreEqual("Dan.Purdy@live.co.uk", p.getEmail);
            Assert.AreEqual("England", p.getCountry);
            Assert.AreEqual("HE IS FINE", p.getMedicalHistory);
            Assert.AreEqual("999", p.getPhoneNumber);
            Assert.AreEqual(true, p.getPresent);
            Assert.AreEqual("College of West Anglia", p.getAddress);
            Assert.AreEqual("PE13 2JE", p.getPostcode);

            //Medicine testing
            string test = instance.encrypt("test");
            Assert.AreEqual(test, instance.encrypt("test"));
            List<Medicine> medlist = instance.GetPrescriptions(p.getPatientID);
            string iString = "2017-11-08 00:00 AM";
            dt = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm tt", null);
            Assert.AreEqual(dt, medlist.ElementAt(0).getEndDate);
            iString = "2017-11-01 00:00 AM";
            dt = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm tt", null);
            Assert.AreEqual(dt, medlist.ElementAt(0).getStartDate);
            Assert.AreEqual(2, medlist.ElementAt(0).getMedicineID);
            Assert.AreEqual("Paracetamol", medlist.ElementAt(0).getMedicineName);
            medlist = instance.getAllMedicine();
            Assert.AreEqual(2, medlist.Count());

            //Test testing
            List<Test> testList = instance.getPatientTests(p.getPatientID);
            Assert.AreEqual(1, testList[0].getTestID);
            Assert.AreEqual("Lobotomy", testList[0].getTestName);
            iString = "2017-11-01 00:00 AM";
            dt = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm tt", null);
            Assert.AreEqual(dt,testList[0].getDate);
            Assert.AreEqual("test1", testList[0].getResult);
            testList = instance.getAllTests();
            Assert.AreEqual(2,testList.Count());

            //Login test
            Staff LoggingInStaff = new Staff();
            LoggingInStaff.getStaffID = 2;
            LoggingInStaff.getpassword = instance.encrypt("password");
            Staff loggedIn = instance.Login(LoggingInStaff.getStaffID, LoggingInStaff.getpassword);
            Assert.IsNotNull(loggedIn);

            //Appointments test
            List<Appointment> appointmentList = instance.getAppointments();
            Assert.AreEqual(14,appointmentList[0].getAppointmentID);
            iString = "2017-11-05 08:00 AM";
            dt = DateTime.ParseExact(iString, "yyyy-MM-dd HH:mm tt", null);
            Assert.AreEqual(dt, appointmentList[0].getDateTime);
            Assert.AreEqual("ScreamAid just increased his screaming", appointmentList[0].getDescription);
        }
    }
}
