using POST_BO;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
using POST_BLL;
namespace POST_View
{
    public class ItemsMenu
    {
        public void ItemMenu()
        {
            WriteLine(format: "{0,68}", arg0: "---Welcome to Items Menu---\n");
            Write("1- Add New Item\n" +
               "2- Update Item details\n" +
               "3- Find Items\n" +
               "4- Removing Existing Item\n" +
               "5- Back to Main Menu\n");
            int? value;
            try
            {
                do
                {
                    Write("\nPress 1 to 5 to select an option: ");
                    value = Convert.ToInt32(ReadLine());
                } while (value < 1 || value > 6) ;
            }
            catch(Exception)
            {
                value = null;
            }
            switch (value)
            {
                case 1:
                    ItemBLL itemBLL1 = new ItemBLL();
                    int id1 = itemBLL1.itemId();
                    Write("\nEnter Item Description: ");
                    string des1 = ReadLine();
                    double? pri1;
                    int? quan1;
                    try
                    {
                        Write("Enter Item Price: ");
                        pri1 = Convert.ToDouble(ReadLine());
                    }
                    catch (Exception)
                    {
                        pri1 = null;
                    }
                    try
                    {
                        Write("Enter Item Quantity: ");
                        quan1 = Convert.ToInt32(ReadLine());
                    }
                    catch (Exception)
                    {
                        quan1 = null;
                    }
                    DateTime dateAndTime1 = DateTime.Now;
                    string date1 = dateAndTime1.ToShortDateString();
                    ItemBO itemBo1 = new ItemBO { itemId = id1, description = des1, price = pri1, quantity = quan1, creationDate = date1 };
                    itemBLL1.addNewItem(itemBo1);
                    ItemMenu();
                    break;
                case 2:
                    Write("\nEnter Item id: ");
                    int? searchId2;
                    try
                    {
                        searchId2 = Convert.ToInt32(ReadLine());
                    }
                    catch
                    {
                        searchId2 = null;
                    }
                    ItemBLL itemBLL2 = new ItemBLL();
                    if (itemBLL2.checkItemId(searchId2) != null)
                    {
                        ItemsMenu im2 = new ItemsMenu();
                        im2.itemIdDisplay(searchId2);
                        Write("\nEnter Item Description: ");
                        string des2 = ReadLine();
                        double? pri2;
                        int? quan2;
                        try
                        {
                            Write("Enter Item Price: ");
                            pri2 = Convert.ToDouble(ReadLine());
                        }
                        catch (Exception)
                        {
                            pri2 = null;
                        }
                        try
                        {
                            Write("Enter Item Quantity: ");
                            quan2 = Convert.ToInt32(ReadLine());
                        }
                        catch (Exception)
                        {
                            quan2 = null;
                        }
                        DateTime dateAndTime2 = DateTime.Now;
                        string date2 = dateAndTime2.ToShortDateString();
                        ItemBO itemBo2 = new ItemBO { itemId = searchId2, description = des2, price = pri2, quantity = quan2, creationDate = date2 };
                        itemBLL2.modifyItemDetails(searchId2, itemBo2);
                    }
                    ItemMenu();
                    break;
                case 3:
                    int? searchId3;
                    double? pri3;
                    int? quan3;
                    try
                    {
                        Write("\nEnter Item id: ");
                        searchId3 = Convert.ToInt32(ReadLine());
                    }
                    catch (Exception)
                    {
                        searchId3 = null;
                    }
                    Write("Enter Item Description: ");
                    string des3 = ReadLine();
                    if (des3 == "")
                    {
                        des3 = null;
                    }
                    try
                    {
                        Write("Enter Item Price: ");
                        pri3 = Convert.ToDouble(ReadLine());
                    }
                    catch (Exception)
                    {
                        pri3 = null;
                    }
                    try
                    {
                        Write("Enter Item Quantity: ");
                        quan3 = Convert.ToInt32(ReadLine());
                    }
                    catch (Exception)
                    {
                        quan3 = null;
                    }
                    Write("Enter Item Date: ");
                    string date3 = ReadLine();
                    if(date3 == "")
                    {
                        date3 = null;
                    }
                    if (searchId3 == null && des3 == null && pri3 == null && quan3 == null && date3 == null)
                    {
                        ItemMenu();
                    }
                    else
                    {
                        ItemBO itemBo3 = new ItemBO { itemId = searchId3, description = des3, price = pri3, quantity = quan3, creationDate = date3 };
                        ItemBLL itemBLL3 = new ItemBLL();
                        ItemsMenu im3 = new ItemsMenu();
                        im3.searchDisplay(itemBLL3.findItem(itemBo3));
                        ItemMenu();
                    }
                    break;
                case 4:
                    Write("\nEnter Item id: ");
                    int? searchId4;
                    try
                    {
                        searchId4 = Convert.ToInt32(ReadLine());
                    }
                    catch
                    {
                        searchId4 = null;
                    }
                
                    ItemBLL itemBLL4 = new ItemBLL();
                    if (itemBLL4.checkItemId(searchId4) != null)
                    {
                        WriteLine("\nItem is Exist");
                        itemBLL4.removeExistingItem(searchId4);
                        ItemMenu();
                    }
                    break;
                case 5:
                    MainMenu mm = new MainMenu();
                    mm.MainMenuInput();
                    break;
                default:
                    ItemMenu();
                    break;
            }
        }


        public void searchDisplay(List<ItemBO> list)
        {
            WriteLine("\n\n-------------------------------------------------------------------------------");
            string formatedString1 = string.Format(format: "{0,6} {1,28} {2,20} {3,20}",
                "Item ID", "Description", "Price", "Quantity");
            WriteLine(formatedString1);
            WriteLine("-------------------------------------------------------------------------------");
            foreach (ItemBO i in list)
            {
                string formatedString2 = string.Format(format: "{0} {1,22} {2,-15} {3,10} {4,-6:N0} {5,10} {6}",
                    i.itemId, "", i.description, "", i.price, "", i.quantity);
                WriteLine(formatedString2);
            }
            WriteLine("-------------------------------------------------------------------------------\n\n");
        }
        public void display()
        {
            ItemBLL bll = new ItemBLL();
            List<ItemBO> list = bll.readItem();
            WriteLine("\n\n-------------------------------------------------------------------------------");
            string formatedString1 = string.Format(format: "{0,6} {1,28} {2,20} {3,20}",
                "Item ID","Description","Price","Quantity");
            WriteLine(formatedString1);
            WriteLine("-------------------------------------------------------------------------------");
            foreach (ItemBO i in list)
            {
                string formatedString2 = string.Format(format: "{0} {1,22} {2,-15} {3,10} {4,-6:N0} {5,10} {6}",
                    i.itemId, "", i.description, "", i.price, "", i.quantity);
                WriteLine(formatedString2);
            }
            WriteLine("-------------------------------------------------------------------------------\n\n");
        }
        public void itemIdDisplay(int? id)
        {
            ItemBLL bll = new ItemBLL();
            List<ItemBO> list = bll.checkItemId(id);
            if (list == null)
            {
                WriteLine("\nItem is not found.");
            }
            else
            {
                WriteLine("\nItem is found.");
            }
            WriteLine("\n\n-------------------------------------------------------------------------------");
            string formatedString1 = string.Format(format: "{0,6} {1,28} {2,20} {3,20}",
                "Item ID", "Description", "Price", "Quantity");
            WriteLine(formatedString1);
            WriteLine("-------------------------------------------------------------------------------");
            foreach (ItemBO i in list)
            {
                string formatedString2 = string.Format(format: "{0} {1,22} {2,-15} {3,10} {4,-6:N0} {5,10} {6}",
                    i.itemId, "", i.description, "", i.price, "", i.quantity);
                WriteLine(formatedString2);
            }
            WriteLine("-------------------------------------------------------------------------------\n\n");
        }
    }
}
