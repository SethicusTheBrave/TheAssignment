using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    public partial class RegisterPatient : Form
    {
        BusinessMetaLayer instance;
        public RegisterPatient()
        {
            InitializeComponent();
            instance = BusinessMetaLayer.instance();
        }

        private void AddToDictionary(string firstName, string lastName, DateTime DOB, string religion, string email, string houseNumber, string street,
                                     string town, string country, string postcode, string phone, string NIN, string tests, string allergies,
                                     string medicalHistory, string notes)
        {
            Dictionary<string, string> patientInformation = new Dictionary<string, string>();
            var format = "yyyy-MM-dd";
            var raktai = new string[] {"firstName","lastName","DOB","religion","email","houseNumber","street","town","country","postcode","phone","NIN","tests","allergies","medicalHistory","notes"};
            patientInformation.Add(raktai[0], firstName);
            patientInformation.Add(raktai[1], lastName);
            patientInformation.Add(raktai[2], DOB.ToString(format));
            patientInformation.Add(raktai[3], religion);
            patientInformation.Add(raktai[4], email);
            patientInformation.Add(raktai[5], houseNumber);
            patientInformation.Add(raktai[6], street);
            patientInformation.Add(raktai[7], town);
            patientInformation.Add(raktai[8], country);
            patientInformation.Add(raktai[9], postcode);
            patientInformation.Add(raktai[10], phone);
            patientInformation.Add(raktai[11], NIN);
            patientInformation.Add(raktai[12], tests);
            patientInformation.Add(raktai[13], allergies);
            patientInformation.Add(raktai[14], medicalHistory);
            patientInformation.Add(raktai[15], notes);
            //  patientInformation = Information;
          //  instance.zodynas(patientInformation, raktai);
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //   instance.RegisterPatients(txtFirstName.Text,txtLastName.Text,dateTimePickerDOB.Value,comboReligion.Text,txtEmail.Text,txtHouseNumber.Text,txtStreet.Text,txtTown.Text,txtCountry.Text,txtPostcode.Text,txtPhone.Text,txtNIN.Text,txtTests.Text,txtAllergies.Text,txtNotes.Text);

            //    AddToDictionary(txtFirstName.Text, txtLastName.Text, dateTimePickerDOB.Value, comboReligion.Text, txtEmail.Text, txtHouseNumber.Text, txtStreet.Text, txtTown.Text, txtCountry.Text, txtPostcode.Text, txtPhone.Text, txtNIN.Text, txtTests.Text, txtAllergies.Text, txtMedicalHistory.Text, txtNotes.Text);
            //  Dictionary<string, string> informaation = new Dictionary<string, string>();
            //     var raktai = new string[] { "firstname", "lastname" };
            //    patientInformation.Add(raktai[0], txtFirstName.Text);
            //     patientInformation.Add(raktai[1], txtLastName.Text);

            //  patientInformation = informaation;
            instance.trinti();
          
          //  instance.zodynas(patientInformation, raktai);




        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            

        }

        private void txtMedicalHistory_TextChanged(object sender, EventArgs e)
        {
            int count = txtMedicalHistory.TextLength;
            int medHistoryLenght = 2500 - count;
            lblMedHistoryCount.Text = medHistoryLenght.ToString() ;
           
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            int count = txtNotes.TextLength;
            int Length = 1500 - count;
            lblMedHistoryCount.Text = Length.ToString();
        }
    }
}
