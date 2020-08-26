using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels {  Freshman, Sophone, Junior, Senior}
        public GradeLevels GradeLevel { get; set; }
        public override float ComputerGradeAverage()
        {
            return 0.0f;
        }

        public override string SendMessage(string message)
        {
            var orginal = base.SendMessage(message);
            var sb = new StringBuilder(orginal);
            sb.AppendLine("This message is private and confidencial");
            return sb.ToString();
        }
    }

}

