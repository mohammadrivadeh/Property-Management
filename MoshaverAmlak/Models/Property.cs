using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshaverAmlak.Models
{
    public class Property
    {
        public long Id { get; set; }
        public string Seller { get; set; }
        public string Area { get; set; }
        public string Floor { get; set; }
        public string Price { get; set; }
        public string SellerMobile { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int PropertyType { get; set; }

    }
}
