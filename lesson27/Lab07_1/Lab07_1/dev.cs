﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class StoreItem
    {
        public int ItemNo { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
    }
}
// namespaces nhà cung cấp
namespace Supply
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}




