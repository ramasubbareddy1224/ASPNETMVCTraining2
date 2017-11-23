using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorials9AM.Models
{
    public class CustomerAddress
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int PINCode { get; set; }
        public int CustomerID { get; set; }
    }
}