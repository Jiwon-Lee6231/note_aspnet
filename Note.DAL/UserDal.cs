using Microsoft.Extensions.Configuration;
using Note.DAL.DataContext;
using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Note.DAL
{
    public class UserDal : IUserDal
    {
        private readonly IConfiguration _configuration;

        public UserDal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User GetUser(int userNo)
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Users.FirstOrDefault(u => u.UserNo.Equals(userNo));
            }
        }

        public List<User> GetUserList()
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Users.ToList();
            }
        }

        public bool AddUser(User user)
        {
            using (var db = new NoteDbContext(_configuration))
            {
                db.Users.Add(user);
                db.SaveChanges();

                return true;
            }
        }

        public User GetUser(string userId, string userPassword)
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Users.FirstOrDefault(u => u.UserId.Equals(userId) && u.UserPassword.Equals(userPassword));
            }
        }
    }
}
