using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mdoau8Eats
{
    public class EatRepository
    {
        SQLiteConnection database;
        public EatRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<DataEat>();
        }
        public IEnumerable<DataEat> GetItems()
        {
            return database.Table<DataEat>().ToList();
        }
        public DataEat GetItem(int id)
        {
            return database.Get<DataEat>(id);
        }
        public DataEat GetName(string name)
        {
            return database.Get<DataEat>(name);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<DataEat>(id);
        }
        public int SaveItem(DataEat item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
