using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Concrete
{
    public class GenreService : IGenreService
    {
        IGenreDAL _genreDAL;

        public GenreService(IGenreDAL genre)
        {
            _genreDAL = genre;
        }

        public void Delete(Genre entity)
        {
            _genreDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Genre genre = _genreDAL.Get(a => a.ID == entityID);
            Delete(genre);
        }

        public Genre Get(int entityID)
        {
            return _genreDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Genre> GetAll()
        {
            return _genreDAL.GetAll();
        }

        public void Insert(Genre entity)
        {
            _genreDAL.Add(entity);
        }

        public void Update(Genre entity)
        {
            _genreDAL.Update(entity);
        }
    }
}
