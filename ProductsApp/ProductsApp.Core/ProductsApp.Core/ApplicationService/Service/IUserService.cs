using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Core.ApplicationServices.Services
{
    public interface IUserService<User>
    {
        public List<User> GetUsers();

        User CreateUser(User user);

        User DeleteUser(int id);

        User UpdateUser(User user);

        User ReadById(int id);



    }
}
