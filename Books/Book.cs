using SqlDB;

namespace Books
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public Genre Genre {  get; set; }
        public double CollateralValue { get; set; }
        public double RentalCoast { get; set; }
        public int Amount { get; set; }

        public Book()
        { }

        public Book (int bookID, string title, int authorID, int genre, 
            double collateralValue, double rentalCoast, int amount)
        {
            BookID = bookID;
            Title = title;
            AuthorID = authorID;
            Genre = (Genre)genre;
            CollateralValue = collateralValue;
            RentalCoast = rentalCoast;
            Amount = amount;
        }

        public static Book SearchBook(string title, int authorID)
        {
            var result = DB.Search<Book>("searchBook", title, "@title", authorID, "@authorID");

            foreach (var entity in result)
            {
                return entity;
            }

            return null;
        }

    }
}
