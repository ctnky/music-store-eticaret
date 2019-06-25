using MusicStore.BLL.Abstract;
using MusicStore.DAL.Abstract;
using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Concrete
{
    public class ShipperService : IShipperService
    {
        IShipperDAL _shipperDAL;

        public ShipperService(IShipperDAL shipper)
        {
            _shipperDAL = shipper;
        }

        public void Delete(Shipper entity)
        {
            _shipperDAL.Remove(entity);
        }

        public void DeleteById(int entityID)
        {
            Shipper shipper = _shipperDAL.Get(a => a.ID == entityID);
            Delete(shipper);
        }

        public Shipper Get(int entityID)
        {
            return _shipperDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Shipper> GetAll()
        {
            return _shipperDAL.GetAll();
        }

        public void Insert(Shipper entity)
        {
            _shipperDAL.Add(entity);
        }

        public void Update(Shipper entity)
        {
            _shipperDAL.Update(entity);
        }
    }
}
