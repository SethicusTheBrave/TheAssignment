using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringAssignment
{
    /// <summary>
    /// This class stores user output messages - success and error information.
    /// /// </summary>
    class DisplayMessages
    {
        // Message is displayed after successful registration of the patient
       public void RegistrationSuccessfull()
        {
            MessageBox.Show("The patient was registered successfully!!!");
        }

        // Message is displayed on failure registering a patient
        public void RegistrationFailed()
        {
            MessageBox.Show("Registration failed! Please make sure you are providing correct data and try again." +
                            "Contact administrator if needed.");
        }
    }
}
