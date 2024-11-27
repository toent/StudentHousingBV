using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Flat
    {
        public int Id { get; set; }
        public int FlatNumber { get; set; }
        public List<Student> Students { get; set; }
        //public List<Chore> Chores { get; set; }
        //public List<Rule> FlatRules { get; set; }
        public List<Complaint> Complaints { get; set; }
        //public List<Agreement> Agreements { get; set; }
        //public List<Grocery> Groceries { get; set; }
        //public List<Announcement> Announcements { get; set; }

        //Empty constructor for deserialization
        public Flat() { }

        //Constructors for regular usage
        public Flat(int buildingId, int flatNumber, DataManager dataManager)   
        {
            this.FlatNumber = flatNumber;
            this.Complaints = new List<Complaint>();
            this.Id = dataManager.GetIdFromClass(this, buildingId); 
        }

        public Flat(int buildingId, int flatNumber, DataManager dataManger, List<Student> students)
        {
            this.FlatNumber = flatNumber;
            this.Complaints = new List<Complaint>();
            this.Students = students;
            this.Id = dataManger.GetIdFromClass(this, buildingId);
        }

        /*public Flat(int buildingId, int flatNumber, DataManager dataManager, List<Rule> rules)
        {
            this.FlatNumber = flatNumber;
            this.Complaints = new List<Complaint>();
            this.FlatRules = rules;
            this.Id = dataManager.GetIdFromClass(this, buildingId);
        }*/

        /*public Flat(int buildingId, int flatNumber, DataManager dataManger, List<Student> students, List<Rule> rules)
        {
            this.FlatNumber = flatNumber;
            this.Complaints = new List<Complaint>();
            this.Students = students;
            this.FlatRules = rules;
            this.Id = dataManger.GetIdFromClass(this, buildingId);
        }*/




        public void AddComplaint(Complaint complaint)
        {
            this.Complaints.Add(complaint);
        }

    }
}
