using System;
using System.Collections.Generic;
using System.Text;

namespace MilkData.DataAccess.DataBaseIn
{
   public interface ISQLiteConn
    {
        SQLite.SQLiteAsyncConnection GetDataBaseConn(string dbName);
    }
}
