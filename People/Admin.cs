using SqlDB;
using System;
using System.IO;
using Books;

namespace People
{
    public static class Admin
    {
        private static int Password = 1111;
        public static int readersCount = 0;
        public static int librariansCount = 0;
        public static double cash = 0;


        public static bool IsPasswordCorrect(int password)
        {
            if (password == Password)
                return true;
            return false;
        }

        public static bool ChangePassword(int oldPswd, int newPswd, int pswd)
        {
            if (oldPswd != Password || newPswd != pswd)
            {
                return false;
            }
            Password = newPswd;
            return true;
        }

        public static string AddLibrarian((string, string, string, string, int, int) librarian)
        {
            if (librarian.Item1.Length < 3 && librarian.Item2.Length < 3 && librarian.Item3.Length < 3)
            {
                return "ФИО должно состоять из слов длиннее 2 букв.";
            }

            if (librarian.Item4.Length < 4)
            {
                return "Адрес должен состоять минимум из 4 букв.";
            }

            if (librarian.Item5 < 1000000 || librarian.Item5 > 9999999)
            {
                return "Телефонный номер должен состоять из 7 цифр.";
            }

            string[] paramNames = {"@surname", "@name", "@patronymic", "@address", "@phoneNumber", "@enPassword"};

            if (DB.AddEntity("addLibrarian", librarian, paramNames))
            {
                Admin.librariansCount = Admin.librariansCount + 1;
                return "Библиотекарь добавлен.";
            }
            else
                return "Ошибка. Библиотекарь не был добавлен.";
        }

        public static Librarian SearchLibrarian(string name, int password)
        {
            var result = DB.Search<Librarian>("searchLibrarian", name, "@username", password, "@password");

            foreach( var entity in result)
            {
                return (Librarian)entity;
            }
            return null;
        }

        public static string DelLibrarian((string, int) librarian)
        {
            string[] paramNames = { "@username", "@password" };

            if (DB.DelEntity("deleteLibrarian", librarian, paramNames))
            {
                Admin.librariansCount = Admin.librariansCount - 1;
                return "Библиотекарь удален";
            }
            else
                return "Ошибка. Библиотекарь не был удален";
        }

        public static string WriteInfo()
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

        public static string ReadInfo()
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

        public static int SearchAuthor(string surname, string name)
        {
            return DB.SearchForID("searchAuthor", surname, "@surname", name, "@name");
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

        public static bool AddBook(string title, string authorSurname, string authorName, 
            Genre genre, double collateral, double rental, int amount)
        {
            int authorId = SearchAuthor(authorSurname, authorName);

            if (authorId == 0)
            {
                string[] paramN = { "@surname", "@name" };
                if (!DB.AddEntity("addAuthor", (authorSurname, authorName), paramN))
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

            return DB.AddEntity("addBook", (title, authorId, Genre, collateral, rental, amount), paramNames);
        }
    }
}