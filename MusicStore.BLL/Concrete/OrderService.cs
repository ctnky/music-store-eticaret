using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Concrete
{
    public class OrderService : IOrderService
    {
        IOrderDAL _orderDAL;

        public OrderService(IOrderDAL order)
        {
            _orderDAL = order;
        }

        public void Delete(Order entity)
        {
            _orderDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Order order = _orderDAL.Get(a => a.ID == entityID);
            Delete(order);
        }

        public Order Get(int entityID)
        {
            return _orderDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Order> GetAll()
        {
            return _orderDAL.GetAll();
        }

        public void Insert(Order entity)
        {
            _orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            _orderDAL.Update(entity);
        }
    }
}
