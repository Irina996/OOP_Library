using SqlDB;
using System;
using System.IO;
using Books;

namespace People
{
    public class Admin
    {
        private int Password = 1111;
        public int readersCount = 0;
        public int librariansCount = 0;
        public int booksCount = 0;
        public double cash = 0;
        private static Admin admin;


        private Admin()
        { }

        public static Admin getInstance()
        {
            if (admin == null)
            {
                admin = new Admin();
            }
            return admin;
        }


        public bool IsPasswordCorrect(int password)
        {
            if (password == Password)
                return true;
            return false;
        }

        public bool ChangePassword(int oldPswd, int newPswd, int pswd)
        {
            if (oldPswd != Password || newPswd != pswd)
            {
                return false;
            }
            Password = newPswd;
            return true;
        }

        public bool AddLibrarian((string, string, string, string, int, int) librarian)
        {
            
            string[] paramNames = {"@surname", "@name", "@patronymic", "@address", "@phoneNumber", "@enPassword"};

            return DB.AddEntity<string, string, string, string, int, int>("addLibrarian", librarian, paramNames);
        }

        public Librarian SearchLibrarian(string name, int password)
        {
            var result = DB.Search<Librarian, string, int>("searchLibrarian", name, "@username", password, "@password");

            foreach( var entity in result)
            {
                return (Librarian)entity;
            }
            return null;
        }

        public bool DelLibrarian((string, int) librarian)
        {
            string[] paramNames = { "@username", "@password" };

            if (DB.DelEntity<string, int>("deleteLibrarian", librarian, paramNames))
            {
                admin.librariansCount = admin.librariansCount - 1;
                return true; ;
            }
            else
                return false;
        }

        public string WriteInfo()
        {
            string writePath = @"..\..\..\People\Info.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(Password);
                    sw.WriteLine(readersCount);
                    sw.WriteLine(librariansCount);
                    sw.WriteLine(booksCount);
                    sw.WriteLine(Math.Round(cash, 2));
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string ReadInfo()
        {
            string path = @"..\..\..\People\Info.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    Password = Convert.ToInt32(sr.ReadLine());
                    readersCount = Convert.ToInt32(sr.ReadLine());
                    librariansCount = Convert.ToInt32(sr.ReadLine());
                    booksCount = Convert.ToInt32(sr.ReadLine());
                    cash = Math.Round((float)Convert.ToDouble(sr.ReadLine()), 2);
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public int SearchAuthor(string surname, string name)
        {
            return Author.SearchAuthor(surname, name);
        }

        // поиск книги по одному из авторов
        public Book SearchBook(string title, int authorID)
        {
            return Book.SearchBook(title, authorID);
        }

        public bool AddBook(string title, string[] authorSurnames, string[] authorNames,
            Genre genre, double collateral, double rental, int amount)
        {
            int[] authorId = new int[authorNames.Length];
            int i = 0;
            foreach(var name in authorNames)
            {
                authorId[i] = SearchAuthor(authorSurnames[i], name);
                i++;
            }

            i = 0;

            foreach (var id in authorId)
            {
                if (id== 0)
                {
                    string[] paramN = { "@surname", "@name" };
                    if (!DB.AddEntity<string>("addAuthor", (authorSurnames[i], authorNames[i]), paramN))
                    {
                        return false;
                    }
                    authorId[i] = SearchAuthor(authorSurnames[i], authorNames[i]);
                }
                i++;
            }

            foreach(var id in authorId) { 
                if (SearchBook(title, id) != null)
                {
                    return false;
                }
            }

            int Genre = (int)genre;
            if (Genre == 0)
            {
                return false;
            }

            string[] paramNames = { "@title", "@genre", "@collateralValue", "@rentalCoast", "@amount" };

            if (DB.AddEntity<string, int, double, double, int>("addBook",
                (title, Genre, collateral, rental, amount), paramNames))
            {
                int bookId = DB.SearchForID("getLastBookID");
                string[] paramNs = { "@bookId", "@authorId" };
                foreach (var id in authorId)
                {
                    try
                    {
                        DB.AddEntity<int>("addBookAuthor", (bookId, id), paramNs);
                    }
                    catch
                    {
                        return false;
                    }
                }
                booksCount += 1;
                return true;
            }

            return false;
        }

        public Reader SearchReaderByID(string surname, int readerID)
        {
            var result = DB.Search<Reader, string, int>("searchReaderByID", surname, "@surname", readerID, "@readerID");

            foreach (var entity in result)
            {
                return entity;
            }

            return null;
        }

        public bool AudioBookIsPaidByReader(Reader reader, Book book)
        {
            var result = DB.SearchForID<int>("isAudioBookPaid", reader.ReaderID, "@readerID", book.BookID, "@bookID");
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public (Book[], Author[][]) GetListOfBooks(int offset, int count)
        {
            var result = DB.Search<Book, int, int>("getListOfBooks", offset, "@offset", count, "@count");

            Book[] books = new Book[count];
            Author[][] authors = new Author[count][];

            int i = 0;
            foreach (var entity in result)
            {
                books[i] = (Book)entity;

                // get authors
                var author_list = DB.Search<Author, int>("getBookAuthors", books[i].BookID, "@bookId");

                int length = 0;
                foreach (var authour in author_list)
                {
                    length++;
                }
                authors[i] = new Author[length];

                int j = 0;
                foreach (var authour in author_list)
                {
                    authors[i][j] = (Author)authour;
                    j++;
                }

                i++;
            }
            return (books, authors);
        }


        public (Book[], Author[][]) GetListOfReaderAudioBooks(int offset, int count, int readerId)
        {
            var result = DB.Search<Book, int, int, int>("getListOfReaderAudioBooks", offset, "@offset", count, 
                "@count", readerId, "@readerId");

            Book[] books = new Book[count];
            Author[][] authors = new Author[count][];

            int i = 0;
            foreach (var entity in result)
            {
                books[i] = (Book)entity;

                // get authors
                var author_list = DB.Search<Author, int>("getBookAuthors", books[i].BookID, "@bookId");

                int length = 0;
                foreach (var authour in author_list)
                {
                    length++;
                }
                authors[i] = new Author[length];

                int j = 0;
                foreach (var authour in author_list)
                {
                    authors[i][j] = (Author)authour;
                    j++;
                }

                i++;
            }
            return (books, authors);
        }

        public (Book[], Author[][]) GetListOfReaderBooks(int offset, int count, int readerId)
        {
            var result = DB.Search<Book, int, int, int>("getListOfReaderBooks", offset, "@offset", count,
                "@count", readerId, "@readerId");

            Book[] books = new Book[count];
            Author[][] authors = new Author[count][];

            int i = 0;
            foreach (var entity in result)
            {
                books[i] = (Book)entity;

                // get authors
                var author_list = DB.Search<Author, int>("getBookAuthors", books[i].BookID, "@bookId");

                int length = 0;
                foreach (var authour in author_list)
                {
                    length++;
                }
                authors[i] = new Author[length];

                int j = 0;
                foreach (var authour in author_list)
                {
                    authors[i][j] = (Author)authour;
                    j++;
                }

                i++;
            }
            return (books, authors);
        }

    }
}