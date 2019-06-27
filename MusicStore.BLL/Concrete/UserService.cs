using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Concrete
{
    public class UserService : IUserService
    {
        IUserDAL _userDAL;

        public UserService(IUserDAL user)
        {
            _userDAL = user;
        }

        public void Delete(User entity)
        {
            _userDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            User user = _userDAL.Get(a => a.ID == entityID);
            Delete(user);
        }

        public User Get(int entityID)
        {
            return _userDAL.Get(a => a.ID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return _userDAL.GetAll();
        }

        public User GetUserByLogin(string username, string password)
        {
            return _userDAL.Get(a => a.UserName == username && a.Password == password);
        }

        public void Insert(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            _userDAL.Update(entity);
        }
    }
}
