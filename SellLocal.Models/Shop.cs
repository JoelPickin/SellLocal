using System;
using System.Collections.Generic;
using System.Text;

namespace SellLocal.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }
        public string Address { get; set; }
        public bool LocalDeliveryOnly { get; set; }
    }
}
