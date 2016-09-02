using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF_Entity_Gyak.Model;

namespace WCF_Entity_Gyak.DAL
{
    public class UserFunctions
    {
        //public Test _db;
        //public UserFunctions()
        //{
        //    _db = new Test();
        //}


        public bool AddUser(string firstName, string lastName, string idCardNumber)
        {
            if (firstName == "" || lastName == "" || idCardNumber == "")
            {
                return false;
            }
            else
            {
                User user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    IdentityCardNumber = idCardNumber
                };

                using (DataBaseContext db = new DataBaseContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                return true;
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            using (DataBaseContext db = new DataBaseContext())
            {
                users = db.Users.ToList();
            }

            return users;
        }

        public User GetUserById(int userId)
        {
            User user;
            using (DataBaseContext db = new DataBaseContext())
            {
                user = db.Users.Where(p => p.Id == userId).FirstOrDefault();
            }
            return user;
        }
    }
}