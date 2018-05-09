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
using HelloWorld;
using SQLite;
using System.IO;
using Xamarin.Forms;
using XAMLUnit1.Droid.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace XAMLUnit1.Droid.Persistence
{

    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {

            var sqliteFilename = "MySQLiteDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);

           /* var db = "TodoSQLite.sqlite";
             var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
                       var path = Path.Combine(documentsPath, db);
           */return new SQLiteAsyncConnection(path);
        }

    }
}