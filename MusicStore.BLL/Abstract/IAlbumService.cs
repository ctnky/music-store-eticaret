using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Abstract
{
    public interface IAlbumService : IBaseService<Album>
    {
        // controller tarafında oluşacak ihtiyaca göre buraya metot oluşturulacak

        List<Album> GetAlbumOfGenre(int genreID);
        List<Album> GetDiscountedAlbums();
        List<Album> GetLastFiveAlbums();
    }
}
