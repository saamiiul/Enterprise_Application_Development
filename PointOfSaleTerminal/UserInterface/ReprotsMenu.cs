using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace POST_View
{
    class ReprotsMenu
    {
        public void getReportsMenuInput()
        {
            WriteLine(format: "{0,70}", arg0: "---Welcome to Reports Menu---\n");
            Write("1- Stock in Hand\n" +
               "2- Customer Balance\n" +
               "3- Sales Report (by date)\n" +
               "4- Outstanding Sales (by Date)\n" +
               "5- Back to Main Menu\n\n");
            int value;
            do
            {
                Write("Press 1 to 5 to select an option: ");
                value = Convert.ToInt32(ReadLine());
            } while (value < 1 || value > 5);
            switch (value)
            {
                case 1:
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:
                    break;
                default:
                    MainMenu mm = new MainMenu();
                    mm.MainMenuInput();
                    break;
            }
        }
    }
}
