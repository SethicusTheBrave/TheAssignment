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
    public partial class AddNote : Form
    {
        Staff m_s;
        Patient m_p;
        public AddNote(Staff p_s, Patient p_p)
        {
            InitializeComponent();
            m_s = p_s;
            m_p = p_p;
            
        }
    }
}
