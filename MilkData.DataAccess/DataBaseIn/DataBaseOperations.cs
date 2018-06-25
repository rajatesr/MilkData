using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MilkData.DataAccess.DataBaseIn
{
    public class DataBaseOperations
    {
        public SQLiteAsyncConnection database;
        public object locks = new object();

        public DataBaseOperations()
        {
            if (DatabaseManager.GetInstance() == null)
                DatabaseManager.Initializeinstance();
            database = DatabaseManager.GetInstance().OpenDataBase();
        }

        public int GetRecountCount(string tableName)
        {
            lock (locks)
            {
                var tempResult = database.ExecuteScalarAsync<int>("select count(*) from" + tableName);
                return tempResult.Result;
            }
        }

        public Task<int> InsertOrReplaceDataInToTable<Tsource>(Tsource data)
        {
            lock (locks)
            {
                var tempResult = database.InsertOrReplaceAsync(data);
                return tempResult;
            }
        }

        public List<Tsource> GetDataFromTable<Tsource>(string query,params object[] data) where Tsource:new()
        {
            lock (locks)
            {
                var tempResult = database.QueryAsync<Tsource>(query,data);
                return tempResult.Result;
            }
        }
    }
}
