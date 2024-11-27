using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Complaint
    {
        public int Id { get; set;  }
        public string Description { get; set; }
        public bool Read { get; set; }

        public Complaint(string description, int buildingId, int flatId, DataManager dataManager)
        {
            this.Description = description;
            this.Read = false;
            this.Id = dataManager.GetIdFromClass(this, buildingId, flatId);
        }

    }
}
