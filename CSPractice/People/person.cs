using System;
using System.Collections.Generic;
using System.Text;

namespace CSPractice.people
{
        public class Person
        {
            public string Name;
            public int Age;
            public bool HasPet;

            public void Greeting()
            {
                Console.WriteLine("Hi my Name is " + Name + " and my age is " + Age + " years");
            }
        }
   
}
