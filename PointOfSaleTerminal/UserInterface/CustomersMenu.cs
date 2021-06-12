using POST_BLL;
using POST_BO;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace POST_View
{
    class CustomersMenu
    {
        public void CustomerMenu()
        {
            WriteLine(format: "{0,72}", arg0: "---Welcome to Customers Menu---\n");
            Write("1- Add New Customer\n" +
               "2- Update Customer details\n" +
               "3- Find Customer\n" +
               "4- Remove Existing Customer\n" +
               "5- Display\n" +
               "6- Back to Main Menu\n\n");
            int? value;
            try
            {
                do
                {
                    Write("Press 1 to 5 to select an option: ");
                    value = Convert.ToInt32(ReadLine());
                } while (value < 1 || value > 6);
            }
            catch(Exception)
            {
                value = null;
            }
            switch (value)
            {
                case 1:
                    CustomerBLL customerBLL1 = new CustomerBLL();
                    int custId1 = customerBLL1.CustomerId();
                    Write("\nEnter Name: ");
                    string custName1 = ReadLine();
                    Write("Enter Address: ");
                    string custAddress1 = ReadLine();
                    Write("Enter Phone Number: ");
                    string custPhone1 = ReadLine();
                    Write("Enter Email: ");
                    string custEmail1 = ReadLine();
                    double? custSL1;
                    try
                    {
                        Write("Enter Sales Limit: ");
                        custSL1 = Convert.ToDouble(ReadLine());
                    }
                    catch (Exception)
                    {
                        custSL1 = null;
                    }
                    CustomerBO customerBO1 = new CustomerBO { customerId = custId1, name = custName1, address = custAddress1, phone = custPhone1, email = custEmail1, amountpayable = 0, salesLimit = custSL1 };
                    customerBLL1.addNewCustomer(customerBO1);
                    CustomerMenu();
                    break;
                case 2:
                    Write("\nEnter Customer id: ");
                    int? searchCustId2;
                    try
                    {
                        searchCustId2 = Convert.ToInt32(ReadLine());
                    }
                    catch
                    {
                        searchCustId2 = null;
                    }
                    CustomerBLL customerBLL2 = new CustomerBLL();
                    if (customerBLL2.checkCustomerId(searchCustId2) != null)
                    {
                        CustomersMenu cm2 = new CustomersMenu();
                        cm2.customerIdDisplay(searchCustId2);
                        Write("\nEnter Name: ");
                        string custName2 = ReadLine();
                        Write("Enter Address: ");
                        string custAddress2 = ReadLine();
                        Write("Enter Phone Number: ");
                        string custPhone2 = ReadLine();
                        Write("Enter Email: ");
                        string custEmail2 = ReadLine();
                        double? custSL2;
                        try
                        {
                            Write("Enter Sales Limit: ");
                            custSL2 = Convert.ToDouble(ReadLine());
                        }
                        catch (Exception)
                        {
                            custSL2 = null;
                        }
                        CustomerBO customerBO2 = new CustomerBO { customerId = searchCustId2, name = custName2, address = custAddress2, phone = custPhone2, email = custEmail2, salesLimit = custSL2 };
                        customerBLL2.modifyCustomerDetails(searchCustId2,customerBO2);
                    }
                    CustomerMenu();
                    break;
                case 3:
                    Write("\nEnter Customer id: ");
                    int? searchCustId3;
                    try
                    {
                        searchCustId3 = Convert.ToInt32(ReadLine());
                    }
                    catch
                    {
                        searchCustId3 = null;
                    }
                    Write("Enter Name: ");
                    string custName3 = ReadLine();
                    Write("Enter Address: ");
                    string custAddress3 = ReadLine();
                    Write("Enter Phone Number: ");
                    string custPhone3 = ReadLine();
                    Write("Enter Email: ");
                    string custEmail3 = ReadLine();
                    double? custSL3;
                    try
                    {
                        Write("Enter Sales Limit: ");
                        custSL3 = Convert.ToDouble(ReadLine());
                    }
                    catch (Exception)
                    {
                        custSL3 = null;
                    }
                    if (searchCustId3 == null && custName3 == null && custAddress3 == null && custPhone3 == null && custEmail3 == null && custSL3 == null)
                    {
                        CustomerMenu();
                    }
                    else
                    {
                        CustomerBO customerBO3 = new CustomerBO { customerId = searchCustId3, name = custName3, address = custAddress3, phone = custPhone3, email = custEmail3, salesLimit = custSL3 }; ;
                        CustomerBLL customerBLL3 = new CustomerBLL();
                        CustomersMenu cm3 = new CustomersMenu();
                        cm3.searchDisplay(customerBLL3.findCustomer(customerBO3));
                        CustomerMenu();
                    }
                    break;
                case 4:
                    Write("\nEnter Customer id: ");
                    int? searchCustId4;
                    try
                    {
                        searchCustId4 = Convert.ToInt32(ReadLine());
                    }
                    catch
                    {
                        searchCustId4 = null;
                    }
                    CustomerBLL customerBLL4 = new CustomerBLL();
                    if (customerBLL4.checkCustomerId(searchCustId4) != null)
                    {
                        WriteLine("\nItem is Exist");
                        customerBLL4.removeExistingCustomer(searchCustId4);
                        CustomerMenu();
                    }
                    break;
                case 5:
                    CustomersMenu cm5 = new CustomersMenu();
                    cm5.display();
                    break;
                case 6:
                    MainMenu mm = new MainMenu();
                    mm.MainMenuInput();
                    break;
                default:
                    CustomerMenu();
                    break;
            }

        }

        public void searchDisplay(List<CustomerBO> list)
        {
            WriteLine("\n\n-------------------------------------------------------------------------------");
            string formatedString1 = string.Format(format: "{0,6} {1,28} {2,20} {3,20} {4,20}",
                "Customer ID", "Name", "Email", "Phone", "Sales Limit");
            WriteLine(formatedString1);
            WriteLine("-------------------------------------------------------------------------------");
            foreach (CustomerBO c in list)
            {
                string formatedString2 = string.Format(format: "{0} {1,22} {2,-15} {3,10} {4,-6} {5,10} {6} {7,10} {8:N2}",
                    c.customerId, "", c.name, "", c.email, "", c.phone, "", c.salesLimit);
                WriteLine(formatedString2);
            }
            WriteLine("-------------------------------------------------------------------------------\n\n");
        }

        public void display()
        {
            CustomerBLL bll = new CustomerBLL();
            List<CustomerBO> list = bll.readCustomer();
            WriteLine("\n\n----------------------------------------------------------------------------------------------------------------");
            string formatedString1 = string.Format(format: "{0,6} {1,20} {2,30} {3,23} {4,23}",
                "Customer ID", "Name", "Email", "Phone", "Sales Limit");
            WriteLine(formatedString1);
            WriteLine("----------------------------------------------------------------------------------------------------------------");
            foreach (CustomerBO c in list)
            {
                string formatedString2 = string.Format(format: "{0} {1,22} {2,-15} {3,10} {4,-6} {5,8} {6,10} {7,-7} {8:N2}",
                    c.customerId, "", c.name, "", c.email, "", c.phone, "", c.salesLimit);
                WriteLine(formatedString2);
            }
            WriteLine("----------------------------------------------------------------------------------------------------------------\n\n");
        }
        public void customerIdDisplay(int? id)
        {
            CustomerBLL bll = new CustomerBLL();
            List<CustomerBO> list = bll.checkCustomerId(id);
            if (list == null)
            {
                WriteLine("\nCustomer is not found.");
            }   
            else
            {
                WriteLine("\nCustomer is found.");
            }
            WriteLine("\n\n-------------------------------------------------------------------------------");
            string formatedString1 = string.Format(format: "{0,6} {1,28} {2,20} {3,20} {4,20}",
                "Customer ID", "Name", "Email", "Phone", "Sales Limit");
            WriteLine(formatedString1);
            WriteLine("-------------------------------------------------------------------------------");
            foreach (CustomerBO c in list)
            {
                string formatedString2 = string.Format(format: "{0} {1,22} {2,-15} {3,10} {4,-6} {5,10} {6} {7,10} {8:N2}",
                    c.customerId, "", c.name, "", c.email, "",c.phone,"", c.salesLimit);
                WriteLine(formatedString2);
            }
            WriteLine("-------------------------------------------------------------------------------\n\n");
        }
    }
}
