using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ReportAssignment : IScore
    {
        public string Title { get; set; }
        public int Chars { get; set; }
        public User Author { get; set; }
        public float Score { get; set;}
        public float MaximumScore { get; set; }
    }
}
