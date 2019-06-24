using MusicStore.Core.DAL.EntityFramework;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DAL.Concrete
{
    public class UserRepository : EFRepositoryBase<User, MusicStoreDbContext>, IUserDAL
    {

    }
}
