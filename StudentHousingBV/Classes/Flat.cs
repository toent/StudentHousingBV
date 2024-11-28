namespace StudentHousingBV.Classes
{
    public class Flat
    {
        public int Id { get; set; }
        public int FlatNumber { get; set; }
        public List<Student> Students { get; set; }
        //public List<Chore> Chores { get; set; }
        public List<Rule> FlatRules { get; set; }
        public List<Complaint> Complaints { get; set; }
        //public List<Agreement> Agreements { get; set; }
        //public List<Grocery> Groceries { get; set; }
        //public List<Announcement> Announcements { get; set; }

        //Empty constructor for deserialization
        public Flat() { }

        //Constructors for regular usage
        public Flat(int buildingId, int flatNumber, DataManager dataManager)
        {
            FlatNumber = flatNumber;
            Complaints = new List<Complaint>();
            Id = dataManager.GetIdFromClass(this, buildingId);
        }

        public Flat(int buildingId, int flatNumber, DataManager dataManger, List<Student> students)
        {
            FlatNumber = flatNumber;
            Complaints = new List<Complaint>();
            Students = students;
            Id = dataManger.GetIdFromClass(this, buildingId);
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
            Complaints.Add(complaint);
        }

    }
}
