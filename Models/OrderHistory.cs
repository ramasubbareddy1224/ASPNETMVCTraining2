using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorials9AM.Models
{
    public class OrderHistory
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int CarModelId { get; set; }
        public decimal Price { get; set; }
        public string status { get; set; }
    }
}