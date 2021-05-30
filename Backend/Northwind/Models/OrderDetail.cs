﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind
{
    public partial class OrderDetail
    {
        public short OrderId { get; set; }
        public short ProductId { get; set; }
        public float UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
