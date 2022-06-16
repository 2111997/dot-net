using System;
using System.Collections.Generic;

#nullable disable

namespace E_Commerce_Api.Models
{
    public partial class AdminDetail
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminLastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
