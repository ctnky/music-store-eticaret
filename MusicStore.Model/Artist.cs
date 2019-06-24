using MusicStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Model
{
    public class Artist : BaseEntity
    {
        public string FullName { get; set; }
        public byte Rating { get; set; }

        // Mapping

        public virtual ICollection<Album> Albums { get; set; }
    }
}
