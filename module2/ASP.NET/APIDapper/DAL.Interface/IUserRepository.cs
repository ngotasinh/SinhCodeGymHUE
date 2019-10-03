using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);
        IList<UserView> GetAllUser();
        User GetUserById(int userId);
    }
}
