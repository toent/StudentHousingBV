using StudentHousingBV.Classes.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.Company_App
{
    public partial class CompanyFlats : Form
    {
        private readonly HousingManager housingManager;

        public CompanyFlats(HousingManager housingManager)
        {
            InitializeComponent();
            this.housingManager = housingManager;
        }
    }
}
