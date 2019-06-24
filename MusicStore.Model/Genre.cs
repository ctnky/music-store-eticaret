using MusicStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Model
{
    public class Genre:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Mapping

        public virtual ICollection<Album> Albums { get; set; }
    }
}
