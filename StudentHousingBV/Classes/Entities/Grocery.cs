using StudentHousingBV.Classes.Managers;
using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Entities
{
    public class Grocery(int id, Student creator, string imagePath, string paymentUrl, Flat assignedFlat, string groceryItems)
    {
        public int GroceryId { get; } = id; // Primary Key
        public DateTime Date { get; } = DateTime.Now;
        public Student? Creator { get; } = creator;
        public string ImagePath { get; set; } = imagePath;
        public string PaymentUrl { get; set; } = paymentUrl;
        public string GroceryItems { get; set; } = groceryItems;
        [JsonIgnore]
        public Flat AssignedFlat { get; set; } = assignedFlat; // Cross-Reference
    }
}
