﻿using ProductsApp.Core.DomainServices;
using ProductsApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository<User>
    {
        readonly DbContext _context;
        public UserRepository(DbContext context)
        {
            _context = context;
        }
        public User CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ReadAllUsers()
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User updateUser)
        {
            throw new NotImplementedException();
        }
    }
}
