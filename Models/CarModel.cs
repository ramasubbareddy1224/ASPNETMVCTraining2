﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTutorials9AM.Models
{
    public class CarModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MakerID { get; set; }
        public decimal Price { get; set; }
    }
}