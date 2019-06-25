using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Concrete
{
    public class ArtistService : IArtistService
    {
        IArtistDAL _artistDAL;

        public ArtistService(IArtistDAL artist)
        {
            _artistDAL = artist;
        }

        public void Delete(Artist entity)
        {
            _artistDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Artist artist = _artistDAL.Get(a => a.ID == entityID);
            Delete(artist);
        }

        public Artist Get(int entityID)
        {
            return _artistDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Artist> GetAll()
        {
            return _artistDAL.GetAll();
        }

        public void Insert(Artist entity)
        {
            _artistDAL.Add(entity);
        }

        public void Update(Artist entity)
        {
            _artistDAL.Update(entity);
        }
    }
}
