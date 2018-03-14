using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ProjectAssignment
    {
        public string Title { get; set; }
        public string[] Deliverables { get; set; }
        public List<User> GroupMembers { get; set; }
    }
}
