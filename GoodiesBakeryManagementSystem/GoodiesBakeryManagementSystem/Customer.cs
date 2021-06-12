using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Microsoft.Data.SqlClient;

namespace GoodiesBakeryManagementSystem
{
    public class Customer
    {
        public void CustomerStartUp()
        {
            string line1 = new String('-', 50);
            string line2 = new String('-', 48);
            WriteLine(format: "\n{0} {1} {2}", arg0: line1, arg1: "  WELCOME CUSTOMER  ", arg2: $"{line2}\n");
            CustomerInput();
        }
        public void CustomerInput()
        {
            WriteLine("\n1- Item Menu\n" +
                "2- Add Items to Cart\n" +
                "3- Pay Bill and get Invoice\n" +
                "4- Exit");
            int? value;
            try
            {
                do
                {
                    Write("\nPress 1 to 4 to select an option: ");
                    value = Convert.ToInt32(ReadLine());
                } while (value < 1 || value > 4);
            }
            catch (Exception)
            {
                Write("\nPlease Enter input between 1 to 4\n");
                value = null;
            }
            switch (value)
            {
                case 1:
                    itemsDisplay();
                    CustomerInput();
                    break;
                case 2:
                    checkItem();
                    CustomerInput();
                    break;
                case 3:
                    payBill();
                    CustomerInput();
                    break;
                case 4:
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.MainMenuInput();
                    break;
                default:
                    CustomerInput();
                    break;
            }
        }
        public void payBill()
        {
            string customerName;
            string customerPhoneNumber;
            do
            {
                Write("\nEnter Name: ");
                customerName = ReadLine();
                if (customerName == "")
                {
                    customerName = null;
                }
                Write("Enter Phone Number: ");
                customerPhoneNumber = ReadLine();
                if (customerPhoneNumber == "")
                {
                    customerPhoneNumber = null;
                }
            } while (customerName == null || customerPhoneNumber == null);
            decimal amount;
            Admin admin = new Admin();
            amount = admin.readCartName();
            string query1 = $"update Cart set CustomerName = @n, CustomerPhoneNumber = @p";
            string query3 = $"DELETE FROM Cart";
            string query2 = $"Insert into Sales (CustomerName, CustomerPhoneNumber, ProductName, Description, Price, Quantity, PurchaseDate) Select CustomerName, CustomerPhoneNumber, ItemName, Description, Price, Quantity, Date From Cart";
            admin.updateCart(query1, customerName, customerPhoneNumber);
            admin.copyRecord(query2);
            Write($"\nYour Total Amount is: {amount}");
            int payAmount;
            do
            {
                try
                {
                    Write("\nPlease Pay Amount: ");
                    payAmount = Convert.ToInt32(ReadLine());
                }
                catch (Exception)
                {
                    payAmount = 0;
                }
                if (payAmount >= amount)
                {
                    admin.Invoice(payAmount);
                    admin.deleteRecord(query3);
                }
                else
                {
                    WriteLine("\nPlease Pay Complete Amount.");
                }
            } while (payAmount < amount);
        }
        public void checkItem()
        {
            Write("\nEnter Item Name: ");
            string itemName = ReadLine();
            if (itemName == "")
            {
                itemName = null;
            }
            int demandQuantity;
            try
            {
                Write("Enter Item Quantity: ");
                demandQuantity = Convert.ToInt32(ReadLine());
            }
            catch (Exception)
            {
                demandQuantity = 0;
            }
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query1 = $"Select Description, Price, Availability from Products where ProductName = @n ";
            SqlParameter p1 = new SqlParameter("n", itemName);
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            cmd1.Parameters.Add(p1);
            connection.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            decimal price = default;
            string description = default;
            int saveQuantity = default;
            while (dr.Read())
            {
                description = Convert.ToString(dr[0]);
                price = Convert.ToDecimal(dr.GetValue(1));
                saveQuantity = Convert.ToInt32(dr.GetValue(2));
            }
            connection.Close();
            if(description == default || price == default || saveQuantity == default)
            {
                WriteLine("\nThis item is not in the list.\n");
                checkItem();
            }
            else
            {
                if (demandQuantity <= saveQuantity)
                {
                    saveQuantity = saveQuantity - demandQuantity;
                    addItemToCart(itemName, demandQuantity, description, price);
                }
                else if (demandQuantity > saveQuantity)
                {
                    if (saveQuantity == 0)
                    {
                        Write("\nThis Item is no More.\n");
                        CustomerInput();
                    }
                    int newQuantity = demandQuantity - saveQuantity;
                    saveQuantity = 0;
                    demandQuantity = demandQuantity - newQuantity;
                    Write("If you want to purchase present items type Yes otherwise No: ");
                    string input = ReadLine();
                    if (input == "Yes")
                    {
                        addItemToCart(itemName, demandQuantity, description, price);
                    }
                    else
                    {
                        CustomerInput();
                    }
                }
            }
              
        }
        public void addItemToCart(string itemName, int? demandQuantity, string description, decimal price)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            if (itemName != null && demandQuantity != null)
            {
                string query = $"insert into Cart (ItemName, Description, Price, Quantity, Date)" + $"values(@n,@des,@p,@q,@dat)";
                SqlParameter p1 = new SqlParameter("n", itemName);
                SqlParameter p2 = new SqlParameter("des", description);
                SqlParameter p3 = new SqlParameter("q", demandQuantity);
                SqlParameter p4 = new SqlParameter("p", price);
                SqlParameter p5 = new SqlParameter("dat", DateTime.Now);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                Write("\nPlease Enter all fields\n");
                checkItem();
            }
        }
        public void cartDisplay()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select * from Cart";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string line1 = new String('-', 120);
            Write($"\n{line1}");
            string formatedString1 = string.Format(format: "{0} {1,14} {2,-5} {3,26} {4,-5} {5,17} {6,-5} {7,13} {8,-5}",
                 "\nItem Name", " ", "Description", " ", "Price", " ", "Quantity", " ", "Date");
            WriteLine(formatedString1);
            Write($"{line1}");
            while (dr.Read())
            {
                string formatedString2 = string.Format(format: "{0} {1,14} {2} {3,26} {4} {5,17} {6} {7,13} {8}",
                 $"{dr[3]}", " ", $"{dr[4]}", " ", $"{dr.GetValue(5)}", " ", $"{dr.GetValue(6)}", " ", $"{Convert.ToDateTime(dr[7]).ToShortDateString()}");
                WriteLine(formatedString2);
            }
            Write($"{line1}\n\n");
            connection.Close();
        }
        public void itemsDisplay()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select ProductName, Price from Products";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string line1 = new String('-', 120);
            Write($"\n{line1}");
            string formatedString1 = string.Format(format: "{0} {1,50} {2,20}",
                 "Product Name", " ", "Price");
            WriteLine(formatedString1);
            Write($"{line1}");
            while (dr.Read())
            {
                string formatedString2 = string.Format(format: "{0} {1,73} {2,-5:N2} ",
                 $"{dr[0]}", " ", $"{Convert.ToDecimal(dr.GetValue(1))}");
                WriteLine(formatedString2);
            }
            connection.Close();
            Write($"{line1}\n");
        }
    }
}