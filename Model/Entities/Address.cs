using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Title { get; set; } = string.Empty;

        //public int UserId { get; set; }
        //public User User { get; set; } = new User();

    }
}
