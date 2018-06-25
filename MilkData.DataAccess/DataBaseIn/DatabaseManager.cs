using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
    
namespace MilkData.DataAccess.DataBaseIn
{
    public class DatabaseManager
    {
        private int dbCounter;
        private static DatabaseManager instanceObj;
        private SQLiteAsyncConnection dataBase;

        public SQLiteAsyncConnection OpenDataBase()
        {
            dbCounter++;
            if (dbCounter == 1)
            {
                // dataBase= DependencyService.Get<ISQLiteConn>().GetDataBaseConn("MilkDB");
            }
            return dataBase;
        }

        public static void Initializeinstance()
        {
            if(instanceObj==null)
            {
                instanceObj = new DatabaseManager();
            }
        }

        public static DatabaseManager GetInstance()
        {
            if(instanceObj==null)
            {
                return null;
            }
            return instanceObj;
        }
    }
}
