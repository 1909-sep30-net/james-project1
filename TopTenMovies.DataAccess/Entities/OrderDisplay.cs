using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenMovies.DataAccess.Entities
{
    public class OrderDisplay
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string ProductTitle { get; set; }
        public string LocationCity { get; set; }
    }
}
