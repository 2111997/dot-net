using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication4.Models
{
    public partial class StudentDatum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? RollNo { get; set; }
        public int? Courseid { get; set; }
    }
}
