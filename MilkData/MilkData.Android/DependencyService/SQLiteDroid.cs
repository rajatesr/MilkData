using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MilkData.DataAccess.DataBaseIn;
using MilkData.Droid.DependencyService;
using SQLite;

[assembly:Xamarin.Forms.Dependency(typeof(SQLiteDroid))]
namespace MilkData.Droid.DependencyService
{
   public class SQLiteDroid : ISQLiteConn
    {

        public SQLiteAsyncConnection GetDataBaseConn(string dbName)
        {
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var dbConn = new SQLiteAsyncConnection(System.IO.Path.Combine(dbPath, dbName));
            return dbConn;
        }
    }
}