using MusicStore.BLL.Abstract;
using MusicStore.Model;
using MusicStore.UI.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.UI.MVC.Controllers
{
    public class OrderController : Controller
    {
        IOrderService _orderService;

        public OrderController(IOrderService order)
        {
            _orderService = order;
        }

        public ActionResult ConfirmCart()
        {
            if (Session["cart"] != null)
            {
                MyCart cart = Session["cart"] as MyCart;
                if (cart.GetAllCartItems.Count > 0)
                {
                    MusicStore.Model.User kullanici = Session["kullanici"] as User;
                    Order order = new Order();
                    order.OrderDate = DateTime.Now;
                    order.ShipAdress = kullanici.Address;
                    order.ShippedDate = DateTime.Now;
                    order.ShipperID = 1;
                    order.Mail = kullanici.Mail;
                    order.UserID = kullanici.ID;
                    order.OrderDetails = new List<OrderDetail>();
                    foreach (CartItemViewModel item in cart.GetAllCartItems)
                    {
                        OrderDetail od = new OrderDetail();
                        od.AlbumID = item.ID;
                        od.Quantity = item.Amount;
                        od.IsCanceled = false;
                        od.Discount = 0;
                        order.OrderDetails.Add(od);
                    }
                    _orderService.Insert(order);
                    Session["cart"] = new MyCart();
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Cart"); ;
        }
    }
}