using POST_BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace POST_DAL
{
    public class CustomerDAL:BaseDAL
    {
        public void saveCustomer(CustomerBO bo)
        {
            string text = $"{bo.customerId},{bo.name},{bo.address},{bo.phone},{bo.email},{bo.amountpayable},{bo.salesLimit} ";
            Save(text, "Customer.csv");
        }
        public void UpdatedSaveCustomer(int? id, CustomerBO bo)
        {
            List<String> stringList = Read("Customer.csv");
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                string text = $"{data[0]},{data[1]},{data[2]},{data[3]},{data[4]},{data[5]},{data[6]}";

                if (Convert.ToInt32(data[0]) == id)
                {
                    text = text = $"{bo.customerId},{bo.name},{bo.address},{bo.phone},{bo.email},{bo.amountpayable},{bo.salesLimit} ";
                }
                Save(text, "UpdatedCustomer.csv");
            }
        }

        public void removeSaveCustomer(int? id)
        {
            List<String> stringList = Read("Customer.csv");
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                string text = $"{data[0]},{data[1]},{data[2]},{data[3]},{data[4]},{data[5]},{data[6]}";
                if (Convert.ToInt32(data[0]) != id)
                {
                    Save(text, "AfterRemoveCustomer.csv");
                }
            }
        }


        public List<CustomerBO> searchCustomer(CustomerBO bo)
        {
            List<String> stringList = Read("Customer.csv");
            List<CustomerBO> list = new List<CustomerBO>();
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                if (Convert.ToInt32(data[0]) == bo.customerId || data[1] == bo.name || data[2] == bo.address || data[3] == bo.phone || data[4] == bo.email || Convert.ToDouble(data[5]) == bo.amountpayable || Convert.ToDouble(data[6]) == bo.salesLimit)
                {
                    CustomerBO c = new CustomerBO();
                    c.customerId = Convert.ToInt32(data[0]);
                    c.name = data[1];
                    c.address = data[2];
                    c.phone = data[3];
                    c.email = data[4];
                    c.amountpayable = Convert.ToDouble(data[5]); 
                    c.salesLimit = Convert.ToDouble(data[6]);
                    list.Add(c);
                    return list;
                }
            }
            list = null;
            return list;
        }



        public List<CustomerBO> readCustomerId(int? id)
        {
            List<String> stringList = Read("Customer.csv");
            List<CustomerBO> list = new List<CustomerBO>();
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                if (Convert.ToInt32(data[0]) == id)
                {
                    CustomerBO c = new CustomerBO();
                    c.customerId = Convert.ToInt32(data[0]);
                    c.name = data[1];
                    c.address = data[2];
                    c.phone = data[3];
                    c.email = data[4];
                    c.amountpayable = Convert.ToDouble(data[5]);
                    c.salesLimit = Convert.ToDouble(data[6]);
                    list.Add(c);
                    return list;
                }
            }
            list = null;
            return list;
        }


        public List<CustomerBO> readCustomer()
        {
            List<String> stringList = Read("Customer.csv");
            List<CustomerBO> list = new List<CustomerBO>();
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                CustomerBO c = new CustomerBO();
                c.customerId = Convert.ToInt32(data[0]);
                c.name = data[1];
                c.address = data[2];
                c.phone = data[3];
                c.email = data[4];
                c.amountpayable = Convert.ToDouble(data[5]);
                c.salesLimit = Convert.ToDouble(data[6]);
                list.Add(c);
            }
            return list;
        }
    }
}
