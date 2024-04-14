using SocketChat.Common.Entities;
using SocketChat.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SocketChat.BLL.Logic
{
    public class UserLogic : IUserLogic
    {
        public async Task Add(User user)
        {
            await UserRepository.AddUser(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await UserRepository.GetAll();
        }

        /*
        public void Add(User user)
        {
            UserRepository.AddUser(user);
        }

        public List<User> GetAll()
        {
            return UserRepository.GetAll();
        }
        */
    }
}
