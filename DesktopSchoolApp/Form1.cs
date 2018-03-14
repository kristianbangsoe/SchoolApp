using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace DesktopSchoolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*get the list of Students from the DB
            var students = DbProvider.GetStudents();
            StringBuilder msg = new StringBuilder("List of students");

            foreach (Student st in students)
            {
                msg.AppendLine(st.Name + " - " + st.Email);
            }

            MessageBox.Show(msg.ToString());
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            School mySchool = new School();
            mySchool.Name = tbName.Text;
            mySchool.PhoneNumber = int.Parse(tbPhone.Text);
            mySchool.ZipCode = int.Parse(tbZip.Text);
            mySchool.Address = tbAddress.Text;
            mySchool.City = tbCity.Text;
            mySchool.TwitterHandle = tbTwitter.Text;
            mySchool.Country = tbCountry.Text;
            mySchool.Website = tbWebsite.Text;

            MessageBox.Show(mySchool.ToString());
        }
    }
}
