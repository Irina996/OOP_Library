using SqlDB;

namespace Books
{
    public class Author
    {
        int AuthorID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

        public Author()
        { }

        public static int SearchAuthor(string surname, string name)
        {
            return DB.SearchForID<string>("searchAuthor", surname, "@surname", name, "@name");
        }

        public static Author GetAuthor(int authorId)
        {
            var result = DB.Search<Author, int>("getAuthor", authorId, "@authorId");

            foreach (var entity in result)
            {
                return (Author)entity;
            }
            return null;
        }
    }
}
