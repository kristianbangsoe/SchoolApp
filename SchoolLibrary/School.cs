using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public int ZipCode
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public int PhoneNumber
        {
            get;
            set;
        }
        public string Website
        {
            get;
            set;
        }
        public string UserType
        {
            get;
            set;
        }

        private string _twitterHandle;
        public string TwitterHandle
        {
            get { return this._twitterHandle; }
            //make sure that the handle starts with an @ symbol
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterHandle = value;
                }
                else
                {
                    throw new Exception("The twitter handle must begin with @");
                }
            }
        }

        public School()
        {

        }
        public School(string schoolName, int phoneNumber)
        {
            Name = schoolName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(Name);
            result.AppendLine(this.Address);
            result.AppendLine(this.PhoneNumber.ToString());
            result.AppendLine(this.ZipCode.ToString());
            result.AppendLine(this.Website);
            result.AppendLine(this.UserType);
            result.AppendLine(this.City);
            result.AppendLine(this.Country);
            return result.ToString();
        }

    }
}
