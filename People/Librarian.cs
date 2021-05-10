using System;
using SqlDB;
using Books;

namespace People
{
    public class Librarian : Person
    {
        public int LibID { get; set; }
        public int EnPassword { get; set; }

        public Librarian() : base()
        {
        }

        public Librarian(int libID, string surname, string name, string patronymic,
            string address, int phoneNumber, int enPassword)
            : base(surname, name, patronymic, address, phoneNumber)
        {
            LibID = libID;
            EnPassword = enPassword;
        }

        public Reader SearchReader(string surname, int phoneNumber)
        {
            var result = DB.Search<Reader>("searchReader", surname, "@surname", phoneNumber, "@phone");

            foreach (var entity in result)
            {
                return entity;
            }

            return null;
        }
        public string AddReader((string, string, string, string, int) reader)
        {
            if (reader.Item1.Length < 3 && reader.Item2.Length < 3 && reader.Item3.Length < 3)
            {
                return "ФИО должно состоять из слов длиннее 2 букв.";
            }

            if (reader.Item4.Length < 4)
            {
                return "Адрес должен состоять минимум из 4 букв.";
            }

            if (reader.Item5 < 1000000 || reader.Item5 > 9999999)
            {
                return "Телефонный номер должен состоять из 7 цифр.";
            }

            string[] paramNames = {"@surname", "@name", "@patronymic", "@address", "@phoneNumber"};

            if (DB.AddEntity("addReader", reader, paramNames))
            {
                Admin.readersCount = Admin.readersCount + 1;
                return "Читатель добавлен.";
            }
            else
                return "Ошибка. Пользователь не был добавлен.";
        }

        public int SearchAuthor(string surname, string name)
        {
            return DB.SearchForID("searchAuthor", surname, "@surname", name, "@name");
        }

        public Book SearchBook(string title, int authorID)
        {
            var result = DB.Search<Book>("searchBook", title, "@title", authorID, "@authorID");
           
            foreach (var entity in result)
            {
                return entity;
            }

            return null;
        }

        public int LastlibCallID()
        {
            return DB.SearchForID("LastLibCallID");
        }

        public bool CreateLibCall((int, int, string, DateTime) libCall)
        {
            string[] paramNames = { "@readerID", "@libID", "@goal", "@date" };

            return DB.AddEntity("createLibraryCall", libCall, paramNames);
        }

        public bool CreateIssuingBook((int, int, DateTime, DateTime) libCall)
        {

            string[] paramNames = { "@bookID", "@libCallID", "@issueDate", "@returnDate" };

            return DB.AddEntity("createIssuingBook", libCall, paramNames);
        }

        public bool ChangeBookAmount(int bookID, int amount)
        {
            string[] paramNames = { "@bookID", "@amount" };
            return DB.ChangeAmount("changeBookAmount", (bookID, amount), paramNames);
        }

        public bool TakePay(int readerID, double pay)
        {
            string[] paramNames = { "@readerID", "pay" };
            return DB.ChangeAmount("changeReaderPay", (readerID, pay), paramNames);
        }
    }
}
