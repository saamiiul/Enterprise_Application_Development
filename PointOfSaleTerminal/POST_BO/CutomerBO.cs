using System;
using System.Collections.Generic;
using System.Text;

namespace POST_BO
{
    public class CustomerBO
    {
        public int? customerId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public double? amountpayable { get; set; }
        public double? salesLimit { get; set; }
    }
}
