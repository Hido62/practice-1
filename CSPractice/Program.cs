using System;
using CSPractice.people;

namespace CSPractice
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "idowu";
            person.Age = 56;
            person.HasPet = true;

            person.Greeting();
        }
    }
}
