using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Agreement
    {
        #region Properties
        public int AgreementId { get; set; } // Primary key
        public string Title { get; set; }
        public string Details { get; set; }
        public List<Student> AgreedBy { get; set; }
        public Student? Student { get; set; }
        public DateTime DateCreated { get; set; }
        public Flat AssignedFlat { get; set; } // Cross-reference
        public HousingManager HousingManager { get; set; }
        #endregion

        #region Constructor
        public Agreement() { }

        public Agreement(string agreementTitle, string agreementDetails, List<Student> studentsInAgreement, Student student, HousingManager housingManager, Flat assignedFlat) 
        {
            AgreementId = housingManager.GetNextAgreementId();
            Title = agreementTitle;
            Details = agreementDetails;
            Student = student;
            HousingManager = housingManager;
            AssignedFlat = assignedFlat;
            DateCreated = DateTime.Now;
        }
        
        #endregion

        #region Methods
        public void AddStudentAgreed(Student student)
        {
            AgreedBy.Add(student);
        }

        public void RemoveStudentAgreed(Student student)
        {
            AgreedBy.Remove(student);
        }
        #endregion
    }
}
