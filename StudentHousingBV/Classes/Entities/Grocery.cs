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
        public Flat AssignedFlat { get; set; } // Cross-Reference

        public Grocery()
        {

        }

        public Grocery(int id, DateTime date, Student creator, string imagePath, string paymentUrl, Flat assignedFlat, string groceryItems)
        {
            GroceryId = id;
            Date = date;
            Creator = creator;
            ImagePath = imagePath;
            PaymentUrl = paymentUrl;
            AssignedFlat = assignedFlat;
            GroceryItems = groceryItems;
        }
    }

}
