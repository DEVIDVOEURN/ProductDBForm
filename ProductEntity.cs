using System;
using System.ComponentModel.DataAnnotations;

namespace ProductDBForm
{
    public class ProductEntity
    {
        [Key]
        public int PId { get; set; }
        public string Product { get; set; }
        public string Descriptions { get; set; }
        public double Price { get; set; }
    }
}
