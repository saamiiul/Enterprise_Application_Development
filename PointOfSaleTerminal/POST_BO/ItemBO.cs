using System;
using System.Collections.Generic;
using System.Text;

namespace POST_BO
{
    public class ItemBO
    {
        public int? itemId { get; set; }
        public string description { get; set; }
        public double? price { get; set; }
        public int? quantity { get; set; }
        public string creationDate { get; set; }
    }
}