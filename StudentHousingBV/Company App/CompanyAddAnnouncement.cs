using StudentHousingBV.Classes.Managers;
using StudentHousingBV.Classes.Entities;
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
    public partial class CompanyAddAnnouncement : Form
    {
        private readonly HousingManager housingManager;
        private Building selectedBuilding;
        internal EventHandler<Announcement> NewAnnouncement;
        public CompanyAddAnnouncement(HousingManager housingManager)
        {
            this.housingManager = housingManager;
            InitializeComponent();
            PopulateComboboxes();
        }

        private void PopulateComboboxes()
        {
            /*
            cbBuilding.DataSource = housingManager.GetBuildings();
            cbBuilding.DisplayMember = "Address";

            if (cbBuilding.SelectedItem is Building building)
            {
                cbFlat.DataSource = building.Flats;
                cbFlat.DisplayMember = "FlatNumber";
            }
            */
        }

        
        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!cbGlobal.Checked)
            //{
            //    selectedBuilding = (Building)cbBuilding.SelectedItem;
            //    cbFlat.DataSource = selectedBuilding.Flats;
            //}
        }

        private void cbGlobal_CheckedChanged(object sender, EventArgs e)
        {
            //if (cbGlobal.Checked)
            //{
            //    cbBuilding.Enabled = false;
            //    cbFlat.Enabled = false;

            //    cbBuilding.SelectedItem = null;
            //    cbFlat.SelectedItem = null;
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           /* Announcement announcement;

            if (cbGlobal.Checked)
            {
                announcement = new Announcement(housingManager.GetNextAnnouncementId(), tbTitle.Text, rtbMessage.Text, cbGlobal.Checked);
                housingManager.AddGlobalAnnouncement(announcement);
            }
            else
            {
                announcement = new Announcement(housingManager.GetNextAnnouncementId(), tbTitle.Text, rtbMessage.Text, cbGlobal.Checked, (Flat)cbFlat.SelectedItem);
                housingManager.AddAnnouncement(announcement);
            }

            NewAnnouncement?.Invoke(this, announcement);*/
        }
    }
}
