using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
namespace POST_View
{
    public class MainMenu
    {
        public void MainMenuInput()
        {
            WriteLine(format: "{0,67}", arg0: "---Welcome to Main Menu---\n");
            WriteLine("1- Manage Items\n" +
                "2- Manage Customers\n" +
                "3- Make New Sale\n" +
                "4- Make Payment\n" +
                "5- Print Reports\n" +
                "6- Exit");
            int? value;
            try
            {
                do
                {
                    Write("\nPress 1 to 6 to select an option: ");
                    value = Convert.ToInt32(ReadLine());
                } while (value < 1 || value > 6);
            }
            catch(Exception)
            {
                value = null;
            }
            switch(value)
            {
                case 1:
                    ItemsMenu im = new ItemsMenu();
                    im.ItemMenu();
                    break;
                case 2:
                    CustomersMenu cm = new CustomersMenu();
                    cm.CustomerMenu();
                    break;
                case 3:

                    break;
                case 4:
                    break;
                case 5:
                    ReprotsMenu rm = new ReprotsMenu();
                    rm.getReportsMenuInput();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    MainMenuInput();
                    break;
            }
        }
    }
}
