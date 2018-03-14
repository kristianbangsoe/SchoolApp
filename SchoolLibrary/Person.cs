using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }

        public abstract float AverageGrade();

        public virtual string SendMessage(string message)
        {
            DateTime dt = new DateTime();
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Message sent on {0} at {1}", dt.Day, dt.TimeOfDay));
            result.AppendLine(message);
            return result.ToString();

        }

        public int GetAge()
        {
            //get the current year
            int currentYear = DateTime.Now.Year;
            //get the Person's year
            int personYear = Birthdate.Year;
            //calculate the year
            int age = currentYear - personYear;
            //return the result
            return age;
        }
    }
}
