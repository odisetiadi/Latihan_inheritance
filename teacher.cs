using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    class teacher : person
    {

        public teacher(string aName, int aAge, string aTeacherId, string aSubject) : base(aName, aAge)
        {
            TeacherId = aTeacherId;
            Subject = aSubject;
        }

        public string TeacherId { get; set; }
        public string Subject { get; set; }

    }
}
