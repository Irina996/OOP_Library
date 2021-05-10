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

        public static int GetIntGenre(string genre)
        {
            switch (genre)
            { 
                case "триллер":
                    return 1;
                case "детектив":
                    return 2;
                case "роман":
                    return 3;
                case "история":
                    return 4;
                case "поэма":
                    return 5;
                case "мистика":
                    return 6;
                case "приключения":
                    return 7;
                case "ужасы":
                    return 8;
                case "фентези":
                    return 9;
                case "фантастика":
                    return 10;
                default:
                    return 0;
            }
        }
    }
}
