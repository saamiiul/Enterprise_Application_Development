using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Blog_Application.Models
{
    public class MembersRepository
    {
        public static void addMember(Member m)
        {
            string conntionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlogApplicationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conntionString);
            string query = $"insert into Members (FirstName, LastName, Email, Password, ConfirmPassword, RegisterDate)" + $"values(@fN,@lN,@e,@p,@cP,@d)";
            SqlParameter p1 = new SqlParameter("fN", m.firstName);
            SqlParameter p2 = new SqlParameter("lN", m.lastName);
            SqlParameter p3 = new SqlParameter("e", m.email);
            SqlParameter p4 = new SqlParameter("p", m.password);
            SqlParameter p5 = new SqlParameter("cP", m.confirmPassword);
            SqlParameter p6 = new SqlParameter("d", DateTime.Now);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static bool checkValidMember(User user)
        {
            string conntionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlogApplicationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(conntionString);
            string query = $"Select  Email, Password  from Members where Email = @e AND Password = @p";
            SqlParameter p1 = new SqlParameter("e", user.email);
            SqlParameter p2 = new SqlParameter("p", user.password);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string email = default;
            string password = default;
            while (dr.Read())
            {
                email = Convert.ToString(dr[0]);
                password = Convert.ToString(dr[1]);
            }
            connection.Close();
            if(email == default || password == default)
            {
                return false;
            }
            return true;
        }
    }
}