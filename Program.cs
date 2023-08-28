namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
       //Encapsulation
     Person person = new Person("MUmbarak", "Basit",2010 );
     person.FullName();
     person.CalcAge();
     

        }
        class Person
        {
            private string LastName { get; set; }
            private string FirstName { get; set; }
            private int YearOfBirth { get; set; }
            public Person(string lastName, string firstName, int yearOfBirth)
            {
                LastName = lastName;
                FirstName = firstName;
                YearOfBirth = yearOfBirth;
            }
            public void FullName()
            {
                Console.WriteLine($"The firstname is {FirstName} and the lastname is {LastName}.");
            }
            public void CalcAge()
            {
                int currentYear = 2023;
                int age = currentYear - YearOfBirth;
                Console.WriteLine($"The age is {age}");
            }
        }



    }
}