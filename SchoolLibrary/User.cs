using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class User : Person
    {
        public enum DegreePrograms
        {
            MultimediaDesign,
            WebDevelopment,
            ComputerScience,
            DConcept
        }
        //public DegreePrograms DegreeProgram { get; set; }

        public override float AverageGrade()
        {
            // TODO: do the actual math & calculate the avg
            var avgGrade = 7.67f;
            return avgGrade;
        }

        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is vonfidential and private.");
            return sb.ToString();
        }

    }
}
