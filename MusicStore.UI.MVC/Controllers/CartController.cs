using MusicStore.BLL.Abstract;
using MusicStore.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.UI.MVC.Controllers
{
    public class CartController : Controller
    {
        IAlbumService _albumService;

        public CartController(IAlbumService album)
        {
            _albumService = album;
        }
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _CartButton()
        {
            return PartialView();
        }

        public ActionResult AddToCart(int id)
        {
            MyCart cart = Session["cart"] as MyCart;
            CartItemViewModel cartItem = new CartItemViewModel();
            var eklenenAlbum = _albumService.Get(id);
            cartItem.ID = eklenenAlbum.ID;
            cartItem.Name = eklenenAlbum.Title;
            cartItem.Price = eklenenAlbum.Discounted ? eklenenAlbum.Price * 0.9m : eklenenAlbum.Price;
            cartItem.Amount = 1;

            cart.AddCart(cartItem);
            Session["cart"] = cart;

            return PartialView("_CartButton");
        }

        public ActionResult _CartList()
        {

            return PartialView();
        }

        public ActionResult UpdateCart(short amount, int id)
        {
            MyCart guncellenenSepet = Session["cart"] as MyCart;
            guncellenenSepet.Update(id, amount);
            Session["cart"] = guncellenenSepet;
            return RedirectToAction("_CartList", "Cart");
        }

        public ActionResult DeleteItemFromCart(int id)
        {
            MyCart silinecekCart = Session["cart"] as MyCart;
            silinecekCart.Delete(id);
            Session["cart"] = silinecekCart;

            return RedirectToAction("_CartList", "Cart");
        }
    }
}