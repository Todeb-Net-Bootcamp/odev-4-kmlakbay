﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsContinue { get; set; }
        public int SizeId { get; set; }

        public Product Product { get; set; }
        public Size Size { get; set; }
    }
}
