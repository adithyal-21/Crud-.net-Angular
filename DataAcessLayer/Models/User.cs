using System;
using System.Collections.Generic;

namespace DataAcessLayer.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public decimal Phone { get; set; }
        public int Age { get; set; }
        public  string Gender { get; set; } = null!;


    }
}
