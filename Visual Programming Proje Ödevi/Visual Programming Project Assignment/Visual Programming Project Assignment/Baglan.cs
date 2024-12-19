using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Programming_Project_Assignment
{
    public class Baglan
    {
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection("Data Source=.\\Veritabani.db;Version=3");
        }
    }
}
