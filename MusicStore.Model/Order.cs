using MusicStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Model
{
    public class Order : BaseEntity
    {
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipperID { get; set; }
        public string ShipAdress { get; set; }
        public string Phone { get; set; }
        public string  Mail { get; set; }

        // Mapping

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual User User { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
