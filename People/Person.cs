namespace People
{
    public abstract class Person
    {
        protected string Surname { get; set; }
        protected string Name { get; set; }
        protected string Patronymic { get; set; }
        protected string Address { get; set; }
        protected int PhoneNumber { get; set; }

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
