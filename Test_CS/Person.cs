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

        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public DateTime Birthday { get; set; }
        public char Gender { get; set; }
        public byte Weigth { get; set; }
        public byte Height { get; set; }
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
            Console.WriteLine("Введите имя: ");
            person._firstname = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            person._secondname = Console.ReadLine();
            Console.WriteLine("Введите дату рождения: (dd.mm.yyyy)");
            try
            {
                person._birthday = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                person._birthday = DateTime.Parse("01.01.1950");
                Console.WriteLine("Дата написана не верно. Установлена дата рождения: 01.01.1950");
            }
            Console.WriteLine("Введите пол: (м/ж)");
            try
            {
                person._gender = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                person._gender = '-';
                Console.WriteLine("Пол написан не верно. Установлен пол '-'");
            }
            Console.WriteLine("Введите вес: ");
            person._weigth = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост: ");
            person._height = byte.Parse(Console.ReadLine());
            return person;
        }

        public string GetPersonInfo()
        {
            return $"{Fullname},Дата рождения: {_birthday.ToShortDateString()}, Возраст: {GetAge()}, Пол: {_gender}, Вес: {_weigth}, Рост: {_height}";
        }
    }
}
