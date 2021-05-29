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
            var result = DB.Search<Librarian>("searchLibrarian", name, "@username", password, "@password");

            foreach( var entity in result)
            {
                return (Librarian)entity;
            }
            return null;
        }

        public bool DelLibrarian((string, int) librarian)
        {
            string[] paramNames = { "@username", "@password" };

            if (DB.DelEntity("deleteLibrarian", librarian, paramNames))
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

        public Book SearchBook(string title, int authorID)
        {
            return Book.SearchBook(title, authorID);
        }

        public bool AddBook(string title, string authorSurname, string authorName, 
            Genre genre, double collateral, double rental, int amount)
        {
            int authorId = SearchAuthor(authorSurname, authorName);

            if (authorId == 0)
            {
                string[] paramN = { "@surname", "@name" };
                if (!DB.AddEntity<string>("addAuthor", (authorSurname, authorName), paramN))
                {
                    return false;
                }
                authorId = SearchAuthor(authorSurname, authorName);
            }

            if (SearchBook(title, authorId) != null)
            {
                return false;
            }

            int Genre = (int)genre;
            if (Genre == 0)
            {
                return false;
            }

            string[] paramNames = { "@title", "@authorId", "@genre", "@collateralValue", "@rentalCoast", "@amount" };

            return DB.AddEntity<string, int, int, double, double, int>("addBook", 
                (title, authorId, Genre, collateral, rental, amount), paramNames);
        }

        public Reader SearchReaderByID(string surname, int readerID)
        {
            var result = DB.Search<Reader>("searchReaderByID", surname, "@surname", readerID, "@readerID");

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

    }
}