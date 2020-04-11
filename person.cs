using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
   public class person
    {
    
            public string Name { get; set; }
            public int Age { get; set; }

            public person(string aName, int aAge)
            {
                Name = aName;
                Age = aAge;

            }
            public void GetNameAndAge()
            {
                Console.WriteLine("The person has name : {0} and age: {1}", Name, Age);


            }

        }

    }
