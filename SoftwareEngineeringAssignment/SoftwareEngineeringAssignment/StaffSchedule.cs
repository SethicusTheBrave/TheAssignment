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
    public partial class StaffSchedule : Form
    {
        BusinessMetaLayer instance = BusinessMetaLayer.instance();
        List<Staff> StaffList = new List<Staff>;
        Staff m_s;
        /// <summary>
        /// View the staff schedule.
        /// </summary>
        public StaffSchedule(Staff p_s)
        {
            InitializeComponent();
            m_s = p_s;


        }
        private void loadSchedule()
        {

        }
    }
}
