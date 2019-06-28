using MusicStore.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        IAlbumService _albumService;
        IGenreService _genreService;

        public HomeController(IAlbumService album, IGenreService genre)
        {
            _albumService = album;
            _genreService = genre;
        }

        // GET: Home
        public ActionResult Index()
        {
            var albums = _albumService.GetAll();
            return View();
        }

        public ActionResult _GenreOfAlbums(int? id)
        {
            if (id != null)
            {
                return PartialView(_albumService.GetAlbumOfGenre(id.Value));
            }

            return PartialView(_albumService.GetAll());
        }

        public ActionResult _GenreMenu()
        {

            return PartialView(_genreService.GetAll());
        }

        public ActionResult _DiscountedAlbums()
        {
            var indirimdekiler = _albumService.GetDiscountedAlbums().ToList();

            if (indirimdekiler.Count == 0)
            {
                ViewBag.Error = "İndirimde ürünümüz bulunmamaktadır";
                return PartialView();
            }

            return PartialView(indirimdekiler);
        }

        public ActionResult _LastFiveAlbums()
        {
            return PartialView(_albumService.GetLastFiveAlbums());
        }
    }
}

