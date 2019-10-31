﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppForShopping.Model
{
    public class ModelCustomer
    {
        public int Id { set; get; }
        public string CustomerCode { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerEmail { set; get; }
        public string Contact { set; get; }
        public int LoyaltyPoint { set; get; }
    }
}
