using MusicStore.DAL.Abstract;
using MusicStore.DAL.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Ninject
{
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAlbumDAL>().To<AlbumRepository>();
            Bind<IArtistDAL>().To<ArtistRepository>();
            Bind<IGenreDAL>().To<GenreRepository>();
            Bind<IOrderDAL>().To<OrderRepository>();
            Bind<IShipperDAL>().To<ShipperRepository>();
            Bind<IUserDAL>().To<UserRepository>();
        }
    }
}
