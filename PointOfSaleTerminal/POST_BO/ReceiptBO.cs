using System;
using System.Collections.Generic;
using System.Text;

namespace POST_BO
{
    class ReceiptBO
    {
        public int receipt { get; set; }
        public string receiptDate { get; set; }
        public int orderId { get; set; }
        public double amount { get; set; }
    }
}
