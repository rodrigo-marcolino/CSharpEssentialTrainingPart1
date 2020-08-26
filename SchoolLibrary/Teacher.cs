using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputerGradeAverage()
        {
            return 0.4f;
        }
    }
}
