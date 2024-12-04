namespace StudentHousingBV.Classes
{
    public class Grocery
    {
        private readonly int groceryId;
        private readonly DateTime date;
        private readonly Student? creator;
        private string imagePath;
        private string paymentUrl;

        public int GroceryId { get => groceryId; }
        public DateTime Date { get => date; }
        public Student? Creator { get => creator; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string PaymentUrl { get => paymentUrl; set => paymentUrl = value; }

        public Grocery(string creatorId, string imagePath, string paymentUrl, DataManager dataManager)
        {
            groceryId = dataManager.GetNextGroceryId();
            date = DateTime.Now;
            creator = dataManager.GetStudent(creatorId);
            this.imagePath = imagePath;
            this.paymentUrl = paymentUrl;
        }
    }
}
