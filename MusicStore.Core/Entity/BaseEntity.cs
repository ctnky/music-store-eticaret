using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Core.Entity
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            IsDeleted = false;
            CreatedDate = DateTime.Now;
        }

        public int ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
