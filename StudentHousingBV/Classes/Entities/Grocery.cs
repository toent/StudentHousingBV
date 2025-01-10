using StudentHousingBV.Classes.Managers;
using System.Text.Json.Serialization;

namespace StudentHousingBV.Classes.Entities
{
    public class Grocery
    {
        public int GroceryId { get; } // Primary Key
        public DateTime Date { get; } = DateTime.Now;
        public Student? Creator { get; }
        public string ImagePath { get; set; }
        public string PaymentUrl { get; set; }
        public string GroceryItems { get; set; }
        [JsonIgnore]
        public Flat AssignedFlat { get; set; } // Cross-Reference

        public Grocery()
        {

        }

        public Grocery(int id, Student creator, string imagePath, string paymentUrl, Flat assignedFlat, string groceryItems)
        {
            GroceryId = id;
            Creator = creator;
            ImagePath = imagePath;
            PaymentUrl = paymentUrl;
            AssignedFlat = assignedFlat;
            GroceryItems = groceryItems;
        }
    }

}
