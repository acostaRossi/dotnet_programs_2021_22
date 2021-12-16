using System.Collections.Generic;

namespace SimpleECommerce
{
    class Seller
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Code { get; set; }
        public List<Product> product { get; set; }
    }
}
