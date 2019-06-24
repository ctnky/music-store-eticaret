using MusicStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Model
{
    public class User : BaseEntity
    {
        public User()
        {
            IsApproved = false;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Notes { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsApproved { get; set; }

        //Mapping

        public virtual ICollection<Order> Orders { get; set; }
    }
}
