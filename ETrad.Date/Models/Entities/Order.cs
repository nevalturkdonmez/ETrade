﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrad.Date.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; } 
        public decimal Total { get; set; }  
        public DateTime OrderDate { get; set; } 
        //public EnumOrderState OrderState { get; set; }
        public string UserName { get; set; }
        public string AddressTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Mahalle { get; set; }
        public string PostalCode { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }

    }
}
