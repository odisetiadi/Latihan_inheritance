using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{ 
    class student:person
    {
            public student(string aName, int aAge, string aStudentId, string aEmail) : base(aName, aAge)
            {
                StudentId = aStudentId;
                Email = aEmail;
            }

            public string StudentId { get; set; }
            public string Email { get; set; }
        }
}
