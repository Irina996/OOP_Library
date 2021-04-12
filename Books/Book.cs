namespace Books
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public Genre Genre { get; set; }
        public float CollateralValue { get; set; }
        public float RentalCost { get; set; }
        public int Amount { get; set; }

        public Book (int bookID, string title, int authorID, int genre, 
            float collateralValue, float rentalCoast, int amount)
        {
            BookID = bookID;
            Title = title;
            AuthorID = authorID;
            Genre = Genre.genre + genre;
            CollateralValue = collateralValue;
            RentalCost = rentalCoast;
            Amount = amount;
        }
    }
}
