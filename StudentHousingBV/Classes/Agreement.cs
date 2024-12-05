namespace StudentHousingBV.Classes
{
    public class Agreement
    {
        #region Properties
        public int AgreementId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public List<Student> AgreedBy { get; set; }
        public string StudentId { get; set; } // Foreign Key
        public int FlatId { get; set; } // Forgein Key
        public int BuildingId { get; set; } // Foreign Key 

        // Navigation properties
        public Student? Student { get; set; }
        public Building? Building { get; set; }
        public Flat? Flat { get; set; }

        #endregion

        #region Constructor
        public Agreement() { }

        public Agreement(string agreementTitle, string agreementDetails, List<Student> studentsInAgreement, 
                            string studentId, int flatId, int buildingId, DataManager dataManager)
        {
            AgreementId = dataManager.GetNextAgreementId();
            Title = agreementTitle;
            Details = agreementDetails;
            AgreedBy = studentsInAgreement;
            StudentId = studentId;
            FlatId = flatId;
            BuildingId = buildingId;
        }
        #endregion

        #region Methods
        public void addStudentAgreed(Student student)
        {
            AgreedBy.Add(student);
        }

        public void removeStudentAgreed(Student student)
        {
            AgreedBy.Remove(student);
        }
        #endregion
    }
}
