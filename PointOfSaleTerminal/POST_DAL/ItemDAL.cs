using POST_BO;
using System;
using System.Collections.Generic;
using System.Text;
namespace POST_DAL
{
    public class ItemDAL:BaseDAL
    {
        public void saveItem(ItemBO bo)
        {
            string text = $"{bo.itemId},{bo.description},{bo.price},{bo.quantity},{bo.creationDate}";
            Save(text, "Item.csv");
        }
        public void UpdatedSaveItem(int? id, ItemBO bo)
        {
            List<String> stringList = Read("Item.csv");
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                string text = $"{data[0]},{data[1]},{data[2]},{data[3]},{data[4]}";

                if (Convert.ToInt32(data[0]) == id)
                {
                    text = $"{bo.itemId},{bo.description},{bo.price},{bo.quantity},{bo.creationDate}";
                }
                Save(text, "UpdatedItem.csv");
            }
            //CopyFile("UpdatedItem.csv", "Item.csv");
        }
        public void removeSaveItem(int? id)
        {
            List<String> stringList = Read("Item.csv");
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                string text = $"{data[0]},{data[1]},{data[2]},{data[3]},{data[4]}";
                if (Convert.ToInt32(data[0]) != id)
                {
                    Save(text, "AfterRemoveItem.csv");
                }
            }
            //CopyFile("AfterRemoveItem.csv", "Item.csv");
        }
        public List<ItemBO> SearchItem(ItemBO bo)
        {
            List<String> stringList = Read("Item.csv");
            List<ItemBO> list = new List<ItemBO>();
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                if (Convert.ToInt32(data[0]) == bo.itemId || data[1] == bo.description || Convert.ToDouble(data[2]) == bo.price || Convert.ToInt32(data[3]) == bo.quantity || data[4] == bo.creationDate)
                {
                    ItemBO i = new ItemBO();
                    i.itemId = Convert.ToInt32(data[0]);
                    i.description = data[1];
                    i.price = Convert.ToDouble(data[2]);
                    i.quantity = Convert.ToInt32(data[3]);
                    list.Add(i);
                    return list;
                }
            }
            list = null;
            return list;
        }
        public List<ItemBO> readItemId(int? id)
        {
            List<String> stringList = Read("Item.csv");
            List<ItemBO> list = new List<ItemBO>();
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                if(Convert.ToInt32(data[0]) == id)
                {
                    ItemBO i = new ItemBO();
                    i.itemId = Convert.ToInt32(data[0]);
                    i.description = data[1];
                    i.price = Convert.ToDouble(data[2]);
                    i.quantity = Convert.ToInt32(data[3]);
                    list.Add(i);
                    return list;
                }
            }
            list = null;
            return list;
        }
        public List<ItemBO> readItem()
        {
            List<String> stringList = Read("Item.csv");
            List<ItemBO> list = new List<ItemBO>();
            foreach (string s in stringList)
            {
                string[] data = s.Split(",");
                ItemBO i = new ItemBO();
                i.itemId = Convert.ToInt32(data[0]);
                i.description = data[1];
                i.price = Convert.ToDouble(data[2]);
                i.quantity = Convert.ToInt32(data[3]);
                list.Add(i);
            }
            return list;
        }
    }
}
