using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class UserBll
    {
        // private UserDal _userDal = new UserDal();
        private readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userNo)
        {
            return _userDal.GetUser(userNo);
        }

        public User GetUser(string userId, string userPassword)
        {
            return _userDal.GetUser(userId, userPassword);
        }

        public List<User> GetUserList()
        {
            return _userDal.GetUserList();
        }

        
    }
}
