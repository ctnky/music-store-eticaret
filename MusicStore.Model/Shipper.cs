using MusicStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Model
{
    public class Shipper : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        // Mapping
        public virtual ICollection<Order> Orders { get; set; }
    }
}
