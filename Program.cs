using System;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            person person = new person("Mike", 20);
            person.GetNameAndAge();

            teacher teacher = new teacher("Thomas", 35, "190302", "Math");
            teacher.GetNameAndAge();

            student student = new student("Sara", 19, "10506", "sara1234@amikom.ac.id");
            student.GetNameAndAge();
            Console.ReadKey();
        }
    }
}
