using MusicStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Model
{
    public class Album:BaseEntity
    {
        public Album()
        {
            Discounted = false;

        }

        public string Title { get; set; }
        public string AlbumUrl { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public bool Discounted { get; set; }

        public int GenreID { get; set; }
        public int ArtistID { get; set; }

        //Mapping

        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
