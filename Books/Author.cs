using SqlDB;

namespace Books
{
    public class Author
    {
        int AuthorID { get; set; }
        string Surname { get; set; }
        string Name { get; set; }

        public static int SearchAuthor(string surname, string name)
        {
            return DB.SearchForID("searchAuthor", surname, "@surname", name, "@name");
        }
    }
}
