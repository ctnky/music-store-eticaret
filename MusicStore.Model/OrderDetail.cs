using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Model
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int AlbumID { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public bool IsCanceled { get; set; } // sipariş iptal olsa da içerdiği bilgi önemli oldugundan duracak.
        public string Notes { get; set; }

        // Mapping

        public virtual Order Order { get; set; }
        public virtual Album Album { get; set; }

    }
}
