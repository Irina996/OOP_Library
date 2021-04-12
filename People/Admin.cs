using SqlDB;
using System;
using System.IO;

namespace People
{
    public static class Admin
    {
        private static int Password = 1111;
        public static int readersCount = 0;
        public static int librariansCount = 0;
        public static float cash = 0;


        public static bool IsPasswordCorrect(int password)
        {
            if (password == Password)
                return true;
            return false;
        }

        public static bool ChangePassword(int oldPswd, int newPswd)
        {
            if (oldPswd != Password)
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
            var result = DB.Search("searchLibrarian", name, "@username", password, "@password");

            if (result.Item2 != null)
            {
                return new Librarian(result.Item1, result.Item2, result.Item3, result.Item4,
                    result.Item5, result.Item6, result.Item7);
            }
            else
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
                return "Ошибкаю Библиотекарь не был удален";
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
                    sw.WriteLine(cash);
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
                    cash = (float)Convert.ToDouble(sr.ReadLine());
                }
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}