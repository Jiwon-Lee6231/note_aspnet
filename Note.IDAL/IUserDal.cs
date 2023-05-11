using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.IDAL
{
    public interface IUserDal
    {
        /// <summary>
        /// 사용자 리스트 출력
        /// </summary>
        /// <returns></returns>
        List<User> GetUserList();

        /// <summary>
        /// 사용자 정보 출력
        /// </summary>
        /// <param name="userNo"></param>
        /// <returns></returns>
        User GetUser(int userNo);

        /// <summary>
        /// 로그인 정보 확인
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User GetUser(string userId, string userPassword);

        /// <summary>
        /// 사용자 등록
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool AddUser(User user);

    }
}
