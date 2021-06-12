using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Microsoft.Data.SqlClient;

namespace GoodiesBakeryManagementSystem
{
    public class MainMenu
    {
        public void MainMenuStartUp()
        {
            string line1 = new String('-', 35);
            string line2 = new String('-', 35);
            WriteLine(format: "\n{0} {1} {2}", arg0: line1, arg1: "  Welcome to GOODIES BAKERY Management System  ", arg2: $"{line2}\n");
            MainMenuInput();
        }
        public void MainMenuInput()
        {
            WriteLine("\n1- Admin\n" +
            "2- Customer\n" +
            "3- Exit");
            int? value;
            try
            {
                do
                {
                    Write("\nPress 1 to 3 to select an option: ");
                    value = Convert.ToInt32(ReadLine());
                } while (value < 1 || value > 3);
            }
            catch (Exception)
            {
                Write("\nPlease Enter input between 1 to 3\n");
                value = null;
            }
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GoodiesBakeryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connString);
            switch (value)
            {
                case 1:
                    Write("\nEnter User Name: ");
                    string userName = ReadLine();
                    Write("Enter Password: ");
                    string pwd = ReadLine();
                    string query = $"Select * from Admins where AdminName  = @u AND Password = @p";
                    
                    SqlParameter p1 = new SqlParameter("u", userName);
                    SqlParameter p2 = new SqlParameter("p", pwd);
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    connection.Open();
                    try
                    {
                        int status = (int)cmd.ExecuteScalar();
                        if (status > 0)
                        {
                            Admin admin = new Admin();
                            admin.AdminStartUp();
                        }
                        connection.Close();
                    }
                    catch(Exception)
                    {
                        WriteLine("\nUser Name or Password is incorrect.\n");
                        MainMenuInput();
                    }
                    break;
                case 2:
                    Customer customer = new Customer();
                    customer.CustomerStartUp();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    MainMenuInput();
                    break;
            }
        }
    }
}
