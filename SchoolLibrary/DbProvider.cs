using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SchoolLibrary
{
    public static class DbProvider
    {
        public static User GetUser()
        {
            User user = new User();
            user.Name = "Mock Student";
            user.Address = "Mockstreet 1, 5000 Odense";
            user.Birthdate = new DateTime(1950, 12, 20);
            user.UserType = "student";

            return user;
        }


        public static List<User> GetUsers(string path)
        {
            //read the content from the json file
            var jsonData = File.ReadAllText(path);
            var format = "yyyy-MM-dd"; // your datetime format 2003-02-29
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };
            //deserialize the json data, convert it to a List of objects of type Student
            var result = JsonConvert.DeserializeObject<List<User>>(jsonData, dateTimeConverter);
            return result;
        }

        public static void SaveUsers(string path, List<User> list)
        {
            //serirliaze the list of Students ==> as json
            var jsonData = JsonConvert.SerializeObject(list, Formatting.Indented);
            //save the json to the file
            File.WriteAllText(path, jsonData);
        }

        public static void SaveUsers(string path)
        {
            //create an ampty List with Student objects
            List<User> users = new List<User>();
            //create 10 objects of type Student
            for (int i = 10; i < 20; i++)
            {
                //give each object a unique value
                User user = new User
                {
                    Id = i + 1,
                    Name = string.Format("teacher{0} Doe", i + 1),
                    Email = "teacher@eal.dk",
                    Address = string.Format("Somestreet {0}, {0}000 Odense", i + 1),
                    Birthdate = new DateTime(1991 + i, 1, i + 1),
                    UserType = string.Format("Teacher"),
                };
                //save the Teacher in the List<>
                users.Add(user);
            }
            //serirliaze the list of Students ==> as json
            var jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            //save the json to the file
            File.WriteAllText(path, jsonData);
        }


    }
}
