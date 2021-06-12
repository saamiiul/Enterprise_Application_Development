using POST_BO;
using POST_DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;
namespace POST_BLL
{
    public class ItemBLL
    {
        public int itemId()
        {
            int id;
            string textFile = Path.Combine(Environment.CurrentDirectory, "ItemId.txt");
            if (File.Exists(textFile))
            {
                StreamReader sr = File.OpenText(textFile);
                id = Convert.ToInt32(sr.ReadToEnd()) + 1;
                sr.Close();
                StreamWriter sw = File.CreateText(textFile);
                sw.WriteLine(id);
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.CreateText(textFile);
                sw.WriteLine("1");
                sw.Close();
                StreamReader sr = File.OpenText(textFile);
                id = Convert.ToInt32(sr.ReadToEnd());
                sr.Close();
            }
            return id;
        }
        public void addNewItem(ItemBO bo)
        {
            string info = "not";
            while(info == "not")
            {
                Write("\nIF you want to save the information type yes otherwise no: ");
                info = ReadLine();
                switch(info)
                {
                    case "yes":
                        break;
                    case "no":
                        break;
                    default:
                        info = "not";
                        break;
                }
            }
            if (info == "yes")
            {
                ItemDAL itemDal = new ItemDAL();
                itemDal.saveItem(bo);
                WriteLine("\nItem Information successfully saved.");   
            }
            else
            {
                WriteLine("\nItem Information not saved.");
            }
        }
        public List<ItemBO> readItem()
        {
            ItemDAL dal = new ItemDAL();
            return dal.readItem();
        }
        public List<ItemBO> checkItemId(int? id)
        {
            ItemDAL dal = new ItemDAL();
            return dal.readItemId(id);
        }
        public void modifyItemDetails(int? id, ItemBO bo)
        {
            string info = "not";
            while (info == "not")
            {
                Write("\nIf you want to save the information type yes otherwise no: ");
                info = ReadLine();
                switch (info)
                {
                    case "yes":
                        break;
                    case "no":
                        break;
                    default:
                        info = "not";
                        break;
                }
            }
            if (info == "yes")
            {
                ItemDAL itemDal = new ItemDAL();
                itemDal.UpdatedSaveItem(id,bo);
                WriteLine("\nItem Information successfully saved.");
            }
            else
            {
                WriteLine("\nItem Information not saved.");
            }
        }
        public List<ItemBO> findItem(ItemBO bo)
        {
            ItemDAL itemDal = new ItemDAL();
            return itemDal.SearchItem(bo);
        }
        public void removeExistingItem(int? id)
        {
            string info = "not";
            while (info == "not")
            {
                Write("\nIf you want to remove the file type yes otherwise no: ");
                info = ReadLine();
                switch (info)
                {
                    case "yes":
                        break;
                    case "no":
                        break;
                    default:
                        info = "not";
                        break;
                }
            }
            if (info == "yes")
            {
                ItemDAL itemDal = new ItemDAL();
                itemDal.removeSaveItem(id);
                WriteLine("\nItem successfully removed.");
            }
            else
            {
                WriteLine("\nItem is not removed.");
            }
        }
    }
}
