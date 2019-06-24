using MusicStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace MusicStore.DAL.Concrete
{
    class OrderDetailMapping : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            HasKey(a => new { a.OrderID, a.AlbumID });
        }
    }
}

