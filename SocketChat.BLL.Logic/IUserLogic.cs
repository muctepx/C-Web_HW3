﻿using SocketChat.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketChat.BLL.Logic
{
    public interface IUserLogic
    {
        public interface IUserLogic
        {
           List<User> GetAll();
            void Add(User user);
            /*
            List<User> GetAll();
            void Add(User user);
            */
        }
    }
}
