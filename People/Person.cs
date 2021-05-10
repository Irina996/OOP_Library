namespace People
{
    public abstract class Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public Person()
        {
        }

        public Person(string surname, string name, string patronymic, string address, int phoneNumber)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
