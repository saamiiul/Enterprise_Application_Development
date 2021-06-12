using System;
using static System.Console;
using Microsoft.Data.SqlClient;
namespace GoodiesBakeryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = new String('-', 50);
            string line2 = new String('-', 50);
            WriteLine(format: "\n{0} {1} {2}", arg0: line1, arg1: "  GOODIES BAKERY  ", arg2: $"{line2}\n");
            MainMenu user = new MainMenu();
            user.MainMenuStartUp();
            WriteLine(format: "\n{0} {1} {2}", arg0: line1, arg1: "  Exit From GOODIES BAKERY  ", arg2: $"{line2}\n");
        }
    }
}
