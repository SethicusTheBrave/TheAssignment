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
            var values = new string[] {"firstName","lastName","DOB","religion","email","houseNumber","street","town","country","postcode","phone","NIN","tests","allergies","medicalHistory","notes"};
            patientInformation.Add(values[0], firstName);
            patientInformation.Add(values[1], lastName);
            patientInformation.Add(values[2], DOB.ToString(format));
            patientInformation.Add(values[3], religion);
            patientInformation.Add(values[4], email);
            patientInformation.Add(values[5], houseNumber);
            patientInformation.Add(values[6], street);
            patientInformation.Add(values[7], town);
            patientInformation.Add(values[8], country);
            patientInformation.Add(values[9], postcode);
            patientInformation.Add(values[10], phone);
            patientInformation.Add(values[11], NIN);
            patientInformation.Add(values[12], tests);
            patientInformation.Add(values[13], allergies);
            patientInformation.Add(values[14], medicalHistory);
            patientInformation.Add(values[15], notes);
           
            instance.RegisterPatients(patientInformation, values);
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

                AddToDictionary(txtFirstName.Text, txtLastName.Text, dateTimePickerDOB.Value, comboReligion.Text, txtEmail.Text, txtHouseNumber.Text, txtStreet.Text, txtTown.Text, txtCountry.Text, txtPostcode.Text, txtPhone.Text, txtNIN.Text, txtTests.Text, txtAllergies.Text, txtMedicalHistory.Text, txtNotes.Text);
            




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
