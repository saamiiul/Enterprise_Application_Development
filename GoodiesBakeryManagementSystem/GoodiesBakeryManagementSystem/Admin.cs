using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Microsoft.Data.SqlClient;

namespace GoodiesBakeryManagementSystem
{
    public class Admin
    {
        static int invNo = 0; 
        public void AdminStartUp()
        {
            string line1 = new String('-', 50);
            string line2 = new String('-', 50);
            WriteLine(format: "\n{0} {1} {2}", arg0: line1, arg1: "  WELCOME ADMIN  ", arg2: $"{line2}\n");
            AdminInput();
        }
        public void AdminInput()
        {
            WriteLine("\n1- Add Item\n" +
                "2- Update Item\n" +
                "3- Delete Item\n" +
                "4- Records\n" +
                "5- Food Inventory Details\n" +
                "6- Add admin\n" +
                "7- Exit");
            int? value;
            try
            {
                do
                {
                    Write("\nPress 1 to 7 to select an option: ");
                    value = Convert.ToInt32(ReadLine());
                } while (value < 1 || value > 7);
            }
            catch (Exception)
            {
                Write("\nPlease Enter input between 1 to 7\n");
                value = null;
            }
            switch (value)
            {
                case 1:
                    addItem();
                    Write("\nItem Added Successfully.\n");
                    AdminInput();
                    break;
                case 2:
                    updateItem();
                    Write("\nItem Updated Successfully.\n");
                    AdminInput();
                    break;
                case 3:
                    deleteItem();
                    Write("\nItem Deleted Successfully.\n");
                    AdminInput();
                    break;
                case 4:
                    records();
                    AdminInput();
                    break;
                case 5:
                    foodInventoryDetails();
                    AdminInput();
                    break;
                case 6:
                    addAdmin();
                    Write("\nAdmin Added Successfully.\n");
                    AdminInput();
                    break;
                case 7:
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.MainMenuInput();
                    break;
                default:
                    AdminInput();
                    break;
            }
        }
        internal void addAdmin()
        {
            string adminName;
            string password;
            do
            {
                Write("\nEnter Admin Name: ");
                adminName = ReadLine();
                if (adminName == "")
                {
                    adminName = null;
                }
                Write("Enter Password: ");
                password = ReadLine();
                if (password == "")
                {
                    password = null;
                }
            } while (adminName == null || password == null);
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"insert into Admins (AdminName, Password)" + $"  values(@n,@p)";
            SqlParameter p1 = new SqlParameter("n", adminName);
            SqlParameter p2 = new SqlParameter("p", password);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void addItem()
        {
            Write("\nEnter Product Name: ");
            string productName = ReadLine();
            if (productName == "")
            {
                productName = null;
            }
            Write("Enter Product Description: ");
            string description = ReadLine();
            if (description == "")
            {
                description = null;
            }
            decimal? price;
            int? availability;
            int? size;
            try
            {
                Write("Enter Product Price: ");
                price = Convert.ToDecimal(ReadLine());
            }
            catch (Exception)
            {
                price = null;
            }
            try
            {
                Write("Enter Product Availability: ");
                availability = Convert.ToInt32(ReadLine());
            }
            catch (Exception)
            {
                availability = null;
            }
            try
            {
                Write("Enter Product Size: ");
                size = Convert.ToInt32(ReadLine());
            }
            catch (Exception)
            {
                size = null;
            }
            string connString1 = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection1 = new SqlConnection(connString1);
            string query1 = $"insert into Products (ProductName, Description, Price, Availability, Size)" +  $"  values(@n,@d,@p,@a,@s)";
            if (productName != null && description != null && price != null && availability != null && size != null)
            {
                SqlParameter p1 = new SqlParameter("n", productName);
                SqlParameter p2 = new SqlParameter("d", description);
                SqlParameter p3 = new SqlParameter("p", price);
                SqlParameter p4 = new SqlParameter("a", availability);
                SqlParameter p5 = new SqlParameter("s", size);
                SqlCommand cmd1 = new SqlCommand(query1, connection1);
                cmd1.Parameters.Add(p1);
                cmd1.Parameters.Add(p2);
                cmd1.Parameters.Add(p3);
                cmd1.Parameters.Add(p4);
                cmd1.Parameters.Add(p5);
                connection1.Open();
                cmd1.ExecuteNonQuery();
                connection1.Close();
            }
            else
            {
                Write("\nPlease Enter all fields\n");
                addItem();
            }
        }
        public void updateItem()
        {
            WriteLine("\n1.To Update Description Enter Product Name and New Price and enter all other fields blank.");
            WriteLine("2.To Update Price Enter Product Name and New Price and enter all other fields blank.");
            WriteLine("3.To Update Availability Enter Product Name and New Price and enter all other fields blank.");
            WriteLine("4.To Update Size Enter Product Name and New Price and enter all other fields blank.");
            Write("\nEnter Product Name: ");
            string productName = ReadLine();
            if (productName == "")
            {
                productName = null;
            }
            Write("Enter Product Description: ");
            string description = ReadLine();
            if (description == "")
            {
                description = null;
            }
            decimal? price;
            int? availability;
            int? size;
            try
            {
                Write("Enter Product Price: ");
                price = Convert.ToDecimal(ReadLine());
            }
            catch(Exception)
            {
                price = null;
            }
            try
            {
                Write("Enter Product Availability: ");
                availability = Convert.ToInt32(ReadLine());
            }
            catch (Exception)
            {
                availability = null; 
            }
            try
            {
                Write("Enter Product Size: ");
                size = Convert.ToInt32(ReadLine());
            }
            catch (Exception)
            {
                size = null;
            }
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            if (description != null && productName != null)
            {
                string query = $"update Products set Description = @d where ProductName = @n";
                SqlParameter p1 = new SqlParameter("n", productName);
                SqlParameter p2 = new SqlParameter("d", description);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (price != null && productName != null)
            {
                string query = $"update Products set Price = @p where ProductName = @n";
                SqlParameter p1 = new SqlParameter("n", productName);
                SqlParameter p3 = new SqlParameter("p", price);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p3);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (availability != null && productName != null)
            {
                string query = $"update Products set Availability = @a where ProductName = @n";
                SqlParameter p1 = new SqlParameter("n", productName);
                SqlParameter p4 = new SqlParameter("a", availability);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p4);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            else if (size != null && productName != null)
            {
                string query = $"update Products set Size = @s where ProductName = @n";
                SqlParameter p1 = new SqlParameter("n", productName);
                SqlParameter p5 = new SqlParameter("s", size);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p5);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void deleteItem()
        {
            int? productId;
            try
            {
                Write("\nEnter Product Id: ");
                productId = Convert.ToInt32(ReadLine());
            }
            catch (Exception)
            {
                productId = null;
            }
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"delete from Products where ProductId = @i";
            SqlParameter p1 = new SqlParameter("i", productId);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void records()
        {
            string line1 = new String(' ', 120);
            string formatedString1 = string.Format(format: "{0} {1,57}",
                $"\n\n{line1}", "Admins");
            Write(formatedString1);
            adminDisplay();
            string formatedString2 = string.Format(format: "{0} {1,57}",
                $"\n\n{line1}", "Products");
            Write(formatedString2);
            productsDisplay();
            string formatedString3 = string.Format(format: "{0} {1,57}",
              $"\n\n{line1}", "Sales");
            Write(formatedString3);
            salesDisplay();
            string formatedString4 = string.Format(format: "{0} {1,57}",
                $"\n\n{line1}", "Cart");
            Write(formatedString4);
            cartDisplay();
        }
        public void salesDisplay()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select * from Sales";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string line1 = new String('-', 120);
            Write($"\n{line1}");
            string formatedString1 = string.Format(format: "{0} {1,5} {2} {3,5} {4} {5,5} {6} {7,5} {8} {9,5} {10} {11,5} {12}",
            "\nCustomer Name", " ", "Customer Phone Number", " ", "Item Name", " ", "Description", " ", "Price", " ", "Quantity", " ", "Date");
            WriteLine(formatedString1);
            Write($"{line1}");
            while (dr.Read())
            {
                string formatedString2 = string.Format(format: "{0} {1,13} {2,-5} {3,14} {4,-5} {5,9} {6,-5} {7,9} {8,-5} {9,8} {10,-5} {11,4} {12,-5}",
                 $"{dr[1]}", " ", $"{dr[2]}", " ", $"{dr[3]}", " ", $"{dr[4]}", " ", $"{dr.GetValue(5)}", " ", $"{dr.GetValue(6)}", " ", $"{Convert.ToDateTime(dr[7]).ToShortDateString()}");
                WriteLine(formatedString2);
            }
            Write($"{line1}\n\n");
            connection.Close();
        }
        public void adminDisplay()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select * from Admins";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string line1 = new String('-', 120);
            Write($"\n{line1}");
            string formatedString1 = string.Format(format: "{0} {1,60} {2}",
                 "\nName", " ", "Password");
            WriteLine(formatedString1);
            Write($"{line1}");
            while (dr.Read())
            {
                string formatedString2 = string.Format(format: "{0} {1,63} {2,-5}",
                 $"{dr[0]}", " ", $"{dr[1]}");
                WriteLine(formatedString2);
            }
            Write($"{line1}\n\n");
            connection.Close();
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
            string formatedString1 = string.Format(format: "{0} {1,10} {2,10} {3,15} {4,10} {5,10} {6,10} {7,10} {8}",
                 "\nItem Name", " ", "Description", " ", "Price", " ", "Quantity", " ", "Date");
            WriteLine(formatedString1);
            Write($"{line1}");
            while (dr.Read())
            {
                string formatedString2 = string.Format(format: "{0} {1,14} {2,-5} {3,26} {4,-5} {5,17} {6,-5} {7,13} {8,-5}",
                 $"{dr[3]}", " ", $"{dr[4]}", " ", $"{dr.GetValue(5)}", " ", $"{dr.GetValue(6)}", " ", $"{Convert.ToDateTime(dr[7]).ToShortDateString()}");
                WriteLine(formatedString2);
            }
            Write($"{line1}\n\n");
            connection.Close();
        }
        public void productsDisplay()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select * from Products";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string line1 = new String('-', 120);
            Write($"\n{line1}");
            string formatedString1 = string.Format(format: "{0} {1,20} {2,20} {3,15} {4,20} {5,15}",
                 "Product ID", "Product Name", "Description", "Price", "Availability", "Size");
            WriteLine(formatedString1);
            Write($"{line1}");
            while (dr.Read())
            {
                string formatedString2 = string.Format(format: "{0} {1,16} {2,-5} {3,16} {4,-5} {5,15} {8,-5} {7,10} {8,-5} {9,13} {10,-5}",
                 $"{dr.GetValue(0)}", " ", $"{dr[1]}", " ", $"{dr[2]}", " ", $"{dr.GetValue(3)}", " ", $"{dr.GetValue(4)}", " ", $"{dr.GetValue(5)}");
                WriteLine(formatedString2);
            }
            WriteLine($"{line1}\n");
            connection.Close();
        }
        public void foodInventoryDetails()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select * from Products";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string line1 = new String('-', 120);
            string line2 = new String('-', 14);
            Write($"\n{line1}");
            string formatedString1 = string.Format(format: "{0} {1,57} {2}",
                 "Product Name", " ", "Availability");
            WriteLine(formatedString1);
            Write($"{line1}");
            while (dr.Read())
            {
                string formatedString2 = string.Format(format: "{0} {1,70} {2,-5}",
                $"{dr[1]}", " ", $"{dr.GetValue(0)}");
                WriteLine(formatedString2);
            }
            Write($"{line1}\n");
            connection.Close();
        }
        public void updateQuantity(string productName, int availability)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"update Products set Availability = @a where ProductName = @n";
            SqlParameter p1 = new SqlParameter("n", productName);
            SqlParameter p2 = new SqlParameter("a", availability);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void readCartQuantity(string itemName, int demandQuantity)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select Availability from Products where ProductName = @n ";
            SqlParameter p = new SqlParameter("n", itemName);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int saveQuantity = default;
            while (dr.Read())
            {
                saveQuantity = Convert.ToInt32(dr.GetValue(0));
            }
            connection.Close();
            if (demandQuantity <= saveQuantity)
            {
                saveQuantity = saveQuantity - demandQuantity;
            }
            else if (demandQuantity > saveQuantity)
            {
                
                int newQuantity = demandQuantity - saveQuantity;
                demandQuantity = demandQuantity - newQuantity;
                saveQuantity = 0;              
            }
            updateQuantity(itemName, saveQuantity);
        }
        public decimal readCartName()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select ItemName, Price, Quantity from Cart";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            decimal price = 0;
            decimal itemAmount = 0;
            decimal totalAmount = 0;
            while (dr.Read())
            {
                readCartQuantity(Convert.ToString(dr[0]), Convert.ToInt32(dr.GetValue(2)));
                price = Convert.ToDecimal(dr.GetValue(1));
                itemAmount = Convert.ToDecimal(dr.GetValue(1)) * Convert.ToInt32(dr.GetValue(2));
                totalAmount = totalAmount + itemAmount;
            }
            connection.Close();
            return totalAmount;
        }
        public void deleteRecord(string query)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void copyRecord(string query)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void updateCart(string query, string name, string phoneNumber)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            SqlParameter p1 = new SqlParameter("n", name);
            SqlParameter p2 = new SqlParameter("p", phoneNumber);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Invoice(decimal netBalance)
        {
            invNo++;
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            string query = $"Select * from Cart";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string line1 = new String('-', 120);
            string line2 = new String('-', 14);
            string format1 = string.Format("{0,68} {1,66}", arg0: "GOODIES BAKERY\n",arg1:line2);
            WriteLine(format1);
            string format2 = string.Format("{0,64}",arg0:"Invoice");
            WriteLine(format2);
            WriteLine($"{line1}");
            
            string format3 = string.Format("{0,10} {1,58} {2,30} {3}",$"Inv No: {invNo}"," ","Date:", $"\t{DateTime.Now.ToShortDateString()}");
            WriteLine(format3);
            string format4 = string.Format("{0,18} {1,50} {2,30} {3}", "M/S: Counter Sale", " ", "Time:", $"\t{DateTime.Now.ToLongTimeString()}");
            WriteLine(format4);
            WriteLine("");
            WriteLine($"{line1}");
            string formatedString1 = string.Format(format: "{0} {1,20} {2,10} {3,20} {4,10} {5,20} {6,10}",
                 "ItemName"," ", "Price", " ", "Quantity", " ", "Total");
            WriteLine(formatedString1);
            int count = 0;
            decimal totalAmount = default;
            WriteLine($"{line1}");
            while (dr.Read())
            {
                    count++;
                    totalAmount = totalAmount + Convert.ToDecimal(dr[5]) * Convert.ToDecimal(dr[6]);
                    string formatedString2 = string.Format(format: "{0,-5} {1,28} {2,-5:N2} {3,25} {4,-5} {5,25} {6,-5}",
                     $"{dr[3]}", " ", $"{dr.GetValue(5)}", " ", $"{dr.GetValue(6)}", " ", $"{Convert.ToDecimal(dr[5]) * Convert.ToDecimal(dr[6])}");
                    WriteLine(formatedString2);
            }
            connection.Close();
            decimal returnBalance = default; 
            if(netBalance > totalAmount)
            {
                returnBalance = netBalance - totalAmount;
            }
            WriteLine($"{line1}");
            string format5 = string.Format("{0,14} {1,54} {2,30} {3}", $"Total Item: {count}", " ", "Total: ", $"{totalAmount}");
            WriteLine(format5);
            WriteLine("\n");
            string format6 = string.Format("{0,35} {1,39} {2,30} {3}", "No return is accepted without bill", " ", "Net Balance: ", $"{netBalance}");
            string format7 = string.Format("{0,78} {1,30} {2}", " ", "Return Balance: ", $"{returnBalance}");
            WriteLine(format6);
            WriteLine(format7);
            WriteLine($"{line1}");
            
        }
    }
}

