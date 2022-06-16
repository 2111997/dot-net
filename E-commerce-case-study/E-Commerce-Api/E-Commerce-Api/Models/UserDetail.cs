using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_Api.Models
{
    public partial class UserDetail
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
