﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinqSamples.Data.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}
