using System;
using SqlDB;
using Books;

namespace People
{
    public class Librarian : Person
    {
        public int LibID { get; set; }
        private int EnPassword { get; set; }

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

        public bool AddReader((string, string, string, string, int) reader)
        {
            string[] paramNames = {"@surname", "@name", "@patronymic", "@address", "@phoneNumber"};

            return DB.AddEntity("addReader", reader, paramNames);
        }

        public bool DelReader((string, int) reader)
        {
            string[] paramNames = { "@username", "@phone" };

            return DB.DelEntity("deleteReader", reader, paramNames);
        }

        public int SearchAuthor(string surname, string name)
        {
            return Author.SearchAuthor(surname, name);
        }

        public Book SearchBook(string title, int authorID)
        {
            return Book.SearchBook(title, authorID);
        }

        public int LastlibCallID()
        {
            return DB.SearchForID("LastLibCallID");
        }

        public bool CreateLibCall((int, int, string, DateTime) libCall)
        {
            string[] paramNames = { "@readerID", "@libID", "@goal", "@date" };

            return DB.AddEntity<int, int, string, DateTime>("createLibraryCall", libCall, paramNames);
        }

        public bool CreateIssuingBook((int, int, DateTime, DateTime) libCall)
        {

            string[] paramNames = { "@bookID", "@libCallID", "@issueDate", "@returnDate" };

            return DB.AddEntity<int, int, DateTime, DateTime>("createIssuingBook", libCall, paramNames);
        }

        public bool ChangeBookAmount(int bookID, int amount)
        {
            string[] paramNames = { "@bookID", "@amount" };
            return DB.ChangeAmount<int, int>("changeBookAmount", (bookID, amount), paramNames);
        }

        public bool TakePay(int readerID, double pay)
        {
            string[] paramNames = { "@readerID", "pay" };
            return DB.ChangeAmount<int, double>("changeReaderPay", (readerID, pay), paramNames);
        }

        public bool PayAudioBook(int readerID, int bookID)
        {
            string[] paramNames = { "@readerID", "@bookID" };
            return DB.AddEntity<int>("payAudioBook", (readerID, bookID), paramNames);
        }
    }
}
