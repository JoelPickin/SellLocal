using SellLocal.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SellLocal.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductText { get; set; }
        public Image ProductImage { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
