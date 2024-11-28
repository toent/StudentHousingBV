using StudentHousingBV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.Student_App
{
    public partial class StudentComplaint : Form
    {
        public StudentComplaint()
        {
            InitializeComponent();
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Complaint submitted successfully!");
        }

        private void changeSelectedTabBgColor()
        {

        }
    }
}
