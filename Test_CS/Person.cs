using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test_CS
{
    internal class Person
    {

        private string _firstname;
        private string _secondname;
        private DateTime _birthday;
        private char _gender;
        private byte _weigth;
        private byte _height;

        public string Firstname 
        {
            get => _firstname;
            set => _firstname = value;
        }
        public string Secondname
        {
            get => _secondname;
            set => _firstname = value;
        }
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }

        public char Gender 
        { 
            get { return _gender; }
            set
            {
                if(Char.IsLower(value))
                {
                    _gender = Char.ToUpper(value);
                }
            }
        }
        public byte Weigth
        {
            get => _weigth;
            set => _weigth = value;
        }
        public byte Height
        {
            get => _height;
            set => _height = value;
        }
        public string Fullname => $"{_firstname} {_secondname}";
        public Person(string firstname, string secondname, DateTime birtday, char gender, byte weigth, byte height)
        {
            _firstname = firstname;
            _secondname = secondname;
            _birthday = birtday;
            _gender = gender;
            _weigth = weigth;
            _height = height;
        }
        public Person() : this(String.Empty, String.Empty, DateTime.MinValue, Char.MinValue, byte.MinValue, byte.MinValue) { }

        public bool IsOlder(int age)
        {
            return GetAge() > age ? true : false;
        }
        public int GetAge()
        {
            int age = DateTime.Today.Year - _birthday.Year;
            return _birthday.Month > DateTime.Today.Month ? age - 1 : age;
        }

        protected Person CreatePerson(Person person)
        {
            Console.WriteLine("Write firstname: ");
            person.Firstname = Console.ReadLine();
            Console.WriteLine("Write secondname: ");
            person.Secondname = Console.ReadLine();
            Console.WriteLine("Write birtday: (dd.mm.yyyy)");
            try
            {
                person.Birthday = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                person.Birthday = DateTime.Parse("01.01.1950");
                Console.WriteLine("The date is spelled incorrectly. Date of birth established: 01.01.1950");
            }
            Console.WriteLine("Choose gender: (m/f)");
            try
            {
                person.Gender = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                person.Gender = '-';
                Console.WriteLine("The gender is spelled incorrectly. The gender is set '-'");
            }
            Console.WriteLine("Write weigth: ");
            person.Weigth = byte.Parse(Console.ReadLine());
            Console.WriteLine("Write height: ");
            person.Height = byte.Parse(Console.ReadLine());
            return person;
        }

        public string GetPersonInfo()
        {
            return $"{Fullname},Birtday: {_birthday.ToShortDateString()}, Age: {GetAge()}, Gender: {_gender}, Weigth: {_weigth}, Height: {_height}";
        }
    }
}
