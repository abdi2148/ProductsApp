using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Core.DomainServices
{
    public interface IUserRepository
    {
        IEnumerable<User> ReadAllUsers();

        public List<User> GetUsers();

        User CreateUser(User user);

        User GetUserById(int id);

        User UpdateUser(User updateUser);

        User DeleteUser(int id);
    }
}
