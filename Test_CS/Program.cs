namespace Test_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            PersonList personList = new PersonList();
            personList.CreateList();
            personList.CreatePersonAddToList();
            personList.FindAllThisBirtdayDate("10.10.2010");
            personList.AverageWeight();
            personList.GetSortedList();
        }
    }
}