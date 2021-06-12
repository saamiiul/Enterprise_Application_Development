using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;
using POST_BO;
using POST_DAL;

namespace POST_BLL
{
    public class CustomerBLL
    {
        public int CustomerId()
        {
            int id;
            string textFile = Path.Combine(Environment.CurrentDirectory, "CustomerId.txt");
            if (File.Exists(textFile))
            {
                StreamReader sr = File.OpenText(textFile);
                id = Convert.ToInt32(sr.ReadToEnd()) + 1;
                sr.Close();
                StreamWriter sw = File.CreateText(textFile);
                sw.WriteLine(id);
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.CreateText(textFile);
                sw.WriteLine("1");
                sw.Close();
                StreamReader sr = File.OpenText(textFile);
                id = Convert.ToInt32(sr.ReadToEnd());
                sr.Close();
            }
            return id;
        }
        public void addNewCustomer(CustomerBO bo)
        {
            string info = "not";
            while (info == "not")
            {
                Write("\nIf you want to save the information type yes otherwise no: ");
                info = ReadLine();
                switch (info)
                {
                    case "yes":
                        break;
                    case "no":
                        break;
                    default:
                        info = "not";
                        break;
                }
            }
            if (info == "yes")
            {
                CustomerDAL customerDal = new CustomerDAL();
                customerDal.saveCustomer(bo);
                WriteLine("\nCustomer Information successfully saved.");
            }
            else
            {
                WriteLine("\nCustomer Information not saved.");
            }
        }
        public List<CustomerBO> checkCustomerId(int? id)
        {
            CustomerDAL dal = new CustomerDAL();
            return dal.readCustomerId(id);
        }
        public void modifyCustomerDetails(int? id, CustomerBO bo)
        {
            string info = "not";
            while (info == "not")
            {
                Write("\nIf you want to save the information type yes otherwise no: ");
                info = ReadLine();
                switch (info)
                {
                    case "yes":
                        break;
                    case "no":
                        break;
                    default:
                        info = "not";
                        break;
                }
            }
            if (info == "yes")
            {
                CustomerDAL customerDal = new CustomerDAL();
                customerDal.UpdatedSaveCustomer(id, bo);
                WriteLine("\nCustomer Information successfully saved.");
            }
            else
            {
                WriteLine("\nCustomer Information not saved.");
            }
        }
        public List<CustomerBO> findCustomer(CustomerBO bo)
        {
            CustomerDAL customerDal = new CustomerDAL();
            return customerDal.searchCustomer(bo);
        }

        public List<CustomerBO> readCustomer()
        {
            CustomerDAL customerDal = new CustomerDAL();
            return customerDal.readCustomer();
        }
        public void removeExistingCustomer(int? id)
        {
            string info = "not";
            while (info == "not")
            {
                Write("\nIf you want to remove the file type yes otherwise no: ");
                info = ReadLine();
                switch (info)
                {
                    case "yes":
                        break;
                    case "no":
                        break;
                    default:
                        info = "not";
                        break;
                }
            }
            if (info == "yes")
            {
                CustomerDAL customerDal = new CustomerDAL();
                customerDal.removeSaveCustomer(id);
                WriteLine("\nCustomer successfully removed.");
            }
            else
            {
                WriteLine("\nCustomer is not removed.");
            }
        }




    }
}
