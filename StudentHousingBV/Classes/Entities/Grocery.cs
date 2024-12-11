using StudentHousingBV.Classes.Managers;

namespace StudentHousingBV.Classes.Entities
{
    public class Grocery(Student creator, string imagePath, string paymentUrl, HousingManager housingManager, Flat assignedFlat)
    {
        public int GroceryId { get; } = housingManager.GetNextGroceryId(); // Primary Key
        public DateTime Date { get; } = DateTime.Now;
        public Student? Creator { get; } = creator;
        public string ImagePath { get; set; } = imagePath;
        public string PaymentUrl { get; set; } = paymentUrl;
        public Flat AssignedFlat { get; set; } = assignedFlat; // Cross-Reference
    }
}
