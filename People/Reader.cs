namespace People
{
    public class Reader : Person
    {
        public int ReaderID { get; set; }
        public int Pay { get; set; }

        public Reader(int readerID, string surname, string name, string patronymic, string address, int phoneNumber, int pay)
            : base(surname, name, patronymic, address, phoneNumber)
        {
            ReaderID = readerID;
            Pay = pay;
        }
        public string Info()
        {
            string str = this.Surname + this.Name + this.PhoneNumber;
            return str;
        }
    }
}
