using System;
using System.Collections.Generic;
using System.Text;

namespace POST_BO
{
    class SaleLineItemBO
    {
        public int lineNo { get; set; }
        public int orderId { get; set; }
        public int itemId { get; set; }
        public int quantity { get; set; }
        public double amount { get; set; }
    }
}
