using System;

namespace People
{
    public class Reader : Person
    {
        public int ReaderID { get; set; }

        // Amount of money that library should return, when reader comes to return all books.
        public double Pay { get; set; }

        public Reader()
        { }

        public Reader(int readerID, string surname, string name, string patronymic, string address, int phoneNumber, double pay)
            : base(surname, name, patronymic, address, phoneNumber)
        {
            ReaderID = readerID;
            Pay = pay;
        }

        public int GetPswd()
        {
            return this.ReaderID*1000 + Convert.ToInt32(this.PhoneNumber/10000);
        }
    }
}
