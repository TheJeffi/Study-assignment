using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CS
{
    internal class PersonList : Person
    {
        private List<Person> _persons;
        public List<Person> Persons { get; set; }

        public void CreateList()
        {
            _persons = new List<Person>();
        }
        
        public void CreatePersonAddToList()
        {
            ConsoleKey consoleKey = ConsoleKey.Y;
            while(consoleKey == ConsoleKey.Y)
            {
                Person person = new Person();
                _persons.Add(CreatePerson(person));
                Console.WriteLine("Добавить нового пользователя? Y - да, любая кнопка для продолжения..");
                consoleKey = Console.ReadKey(true).Key;
            } 
        }

        public void AverageWeight()
        {
            double averageWeight = 0D;
            int childrenCount = 0;
            for (int i = 0; i < _persons.Count; i++)
            {
                if (!_persons[i].IsOlder(18))
                {
                    averageWeight += _persons[i].Weigth;
                    childrenCount++;
                }
            }
            Console.WriteLine($"Средний вес детей младше 18 лет = {averageWeight / childrenCount}");
        }

        public  void FindAllThisBirtdayDate(string date)
        {
            DateTime tempDate = DateTime.Parse(date);
            int count = 0;
            for (int i = 0; i < _persons.Count; i++)
            {
                if (_persons[i].Birthday == tempDate)
                {
                    count++;
                }
            }
            Console.WriteLine($"Кол-во людей родившихся {date} = {count}");
        }

        public void GetSortedList()
        {
            _persons.Sort(delegate (Person x, Person y)
            {
                if (x.Height == byte.MinValue && y.Height == byte.MinValue) return 0;
                else if (x.Height == byte.MinValue) return 1;
                else if (y.Height == byte.MinValue) return -1;
                else return y.Height.CompareTo(x.Height);
            });
            for (int i = 0; i < _persons.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{_persons[i].GetPersonInfo()}");
            }
        }
    }
}
