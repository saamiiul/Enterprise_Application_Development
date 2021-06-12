using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using static System.Console;
using POST_View;
namespace PointOfSaleTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(format: "{0,72}", arg0: "------Point of Sale Terminal------\n");
            MainMenu user = new MainMenu();
            user.MainMenuInput();
        }
    }
}