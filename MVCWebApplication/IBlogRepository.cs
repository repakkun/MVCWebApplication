using MVCWebApplication.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication
{
    public interface IBlogRepository
    {
        Task<User[]> GetUsers();
        Task AddUser(User user);
    }
}
