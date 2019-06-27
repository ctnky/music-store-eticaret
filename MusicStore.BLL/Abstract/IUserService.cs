using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        User GetUserByLogin(string username, string password);
    }
}
