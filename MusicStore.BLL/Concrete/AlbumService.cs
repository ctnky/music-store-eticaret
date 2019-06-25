using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Concrete
{
    public class AlbumService : IAlbumService
    {
        IAlbumDAL _albumDAL;

        public AlbumService(IAlbumDAL album)
        {
            _albumDAL = album;
        }

        public void Delete(Album entity)
        {
            _albumDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Album album = _albumDAL.Get(a => a.ID == entityID);
            Delete(album);
        }

        public Album Get(int entityID)
        {
            return _albumDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Album> GetAll()
        {
            return _albumDAL.GetAll();
        }

        public void Insert(Album entity)
        {
            _albumDAL.Add(entity);
        }

        public void Update(Album entity)
        {
            _albumDAL.Update(entity);
        }
    }
}
